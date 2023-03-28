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
        private const string PATH_COURSES = "kolegiji.txt";
        private const string PATH_PERSONS = "osobe.txt";
        private const string PATH_NOTIFICATIONS = "obavijesti.txt";

        public FileRepo()
        {
            CreateFileIfNotExist();
        }


        private void CreateFileIfNotExist()
        {
            if (!File.Exists(PATH_COURSES))
            {
                File.Create(PATH_COURSES).Close();
            }
            if (!File.Exists(PATH_PERSONS))
            {
                File.Create(PATH_PERSONS).Close();
            }
            if (!File.Exists(PATH_NOTIFICATIONS))
            {
                File.Create(PATH_NOTIFICATIONS).Close();
            }
        }




        public IList<Person> GetPersons()
        {
            IList<Person> persons = new List<Person>();
            string[] data = File.ReadAllLines(PATH_PERSONS);
                        
            foreach (string line in data)
            {
                    try
                    {
                        persons.Add(Person.ParseFromFile(line));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("parser za osobu je puko"+ex.Message);
                    }
                                   
            }

            return persons;
        }

        public IList<Course> GetCourses()
        {
            IList<Course> courses = new List<Course>();
            string[] data = File.ReadAllLines(PATH_COURSES);

            foreach (string line in data)
            {
               courses.Add(Course.ParseFromFile(line));
            }

            return courses;
        }




        public void SavePersonData(IList<Person> persons)
        {
            List<string> lines = new List<string>();

            foreach (Person person in persons)
            {
                lines.Add(person.FormatForFile());
            }

            File.WriteAllLines(PATH_PERSONS, lines);


        }


        public void SaveCourseData(IList<Course> courses)
        {
            List<string> lines = new List<string>();

            foreach (Course person in courses)
            {
                lines.Add(person.FormatForFile());
            }

            File.WriteAllLines(PATH_COURSES, lines);


        }
    }
}
