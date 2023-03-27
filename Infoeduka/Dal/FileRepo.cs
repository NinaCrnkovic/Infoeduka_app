using Infoeduka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Dal
{
    class FileRepo : IRepo
    {
        private const string PATH = "podaci.txt";

        public FileRepo()
        {
            CreateFileIfNotExist();
        }


        private void CreateFileIfNotExist()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }




        public IList<Person> GetPersons()
        {
            IList<Person> persons = new List<Person>();
            string[] lines = File.ReadAllLines(PATH);

            bool isLecturersSection = false;
            foreach (string line in lines)
            {
                if (line.StartsWith("Predavači:"))
                {
                    isLecturersSection = true;
                    continue;
                }
                else if (line.StartsWith("Kolegiji:"))
                {
                    isLecturersSection = false;
                    continue;
                }

                if (isLecturersSection)
                {
                    persons.Add(Person.ParseFromFile(line));
                }
            }

            return persons;
        }

        public IList<Course> GetCourses()
        {
            IList<Course> courses = new List<Course>();
            string[] lines = File.ReadAllLines(PATH);

            bool isCoursesSection = false;
            foreach (string line in lines)
            {
                if (line.StartsWith("Kolegiji:"))
                {
                    isCoursesSection = true;
                    continue;
                }
                else if (line.StartsWith("Predavači:"))
                {
                    isCoursesSection = false;
                    continue;
                }

                if (isCoursesSection)
                {
                    courses.Add(Course.ParseFromFile(line));
                }
            }

            return courses;
        }




        public void SaveData(IList<Person> persons, IList<Course> courses)
        {
            using (StreamWriter writer = new StreamWriter(PATH))
            {
                // Spremanje osoba
                writer.WriteLine("Predavači:");
                foreach (Person person in persons)
                {
                    string line = person.FormatForFile();
                    writer.WriteLine(line);
                }
                writer.WriteLine();

                // Spremanje kolegija
                writer.WriteLine("Kolegiji:");
                foreach (Course course in courses)
                {
                    string line = course.FormatForFile();
                    writer.WriteLine(line);
                }
            };
        }
    }
}
