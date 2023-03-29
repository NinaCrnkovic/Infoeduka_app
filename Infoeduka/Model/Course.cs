using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Model
{
    public class Course
    {
        private const char DEL = '#';
        public string Id { get; private set; } = "";
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public int Ects { get; set; } = 0;
        public List<Person> Lecturers { get; set; } = new List<Person>();

        public Course()
        {

        }

        public Course( string name, string code, int ects, List<Person> lecturers)
        {
            Id = code;
            Name = name;
            Code = code;
            Ects = ects;
            Lecturers = lecturers;
        }

     

        public override string ToString() => $"{Id}, {Name}, {Code}, {Ects}, {Lecturers?.ToString()}";



        public string FormatForFile()
        {
            string lecturers = Lecturers.Any() ? string.Join(DEL, Lecturers.Select(l => l.FormatForFile())) : "";

            return $"{Id}{DEL}{Name}{DEL}{Code}{DEL}{Ects}{DEL}{lecturers}";


        }
        public static Course ParseFromFile(string line)
        {
            string[] parts = line.Split(DEL);
            if (parts.Length < 5)
                throw new ArgumentException("Invalid line format: " + line);

         

            var course = new Course
            {
            
                Name = parts[0],
                Code = parts[1],
                Ects = int.Parse(parts[2])
            };


            string[] peopleInfo = parts[3].Split(DEL);
            foreach (string personInfo in peopleInfo)
            {
                Person lecturer = Person.ParseFromFile(personInfo);
                if (lecturer != null)
                    course.Lecturers.Add(lecturer);
            }

            return course;
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Id.Equals(course.Id) &&
                   Name == course.Name &&
                   Code == course.Code &&
                   Ects == course.Ects &&
                   EqualityComparer<List<Person>>.Default.Equals(Lecturers, course.Lecturers);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Code, Ects, Lecturers);
        }
    }
}
