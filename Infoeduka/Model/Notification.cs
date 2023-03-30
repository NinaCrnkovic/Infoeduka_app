using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Infoeduka.Model
{
    public class Notification
    {
        private const char DEL = '|';
        private const string DATEFORMAT = "dd.MM.yyyy";
        public Notification(string name, string description, Course course, Person creator, DateTime expirationDate)
        {
            Id = Utility.GenerateRandomId();
            Name = name;
            Description = description;
            Course = course;
            Creator = creator;
            DateOfChange = DateOfCreation;
            ExpirationDate = expirationDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
        public Person Creator { get; set; }
        public DateTime DateOfCreation { get; } = DateTime.Now;
        
        private DateTime _dateOfChange;

        public DateTime DateOfChange
        {
            get { return _dateOfChange; }
            set
            {
                if (_dateOfChange != value && value > DateOfCreation)
                {
                    _dateOfChange = value;
                }
            }
        }
        public DateTime ExpirationDate { get; set; }


        public static void ParseToFile(Notification notification, string filePath)
        {
            string line = $"{notification.Id}{DEL}{notification.Name}{DEL}{notification.Description}{DEL}{notification.Course.Id}{DEL}{notification.Creator.Id}{DEL}{notification.DateOfCreation.ToString(DATEFORMAT)}{DEL}{notification.DateOfChange.ToString(DATEFORMAT)}{DEL}{notification.ExpirationDate.ToString(DATEFORMAT)}";
            File.AppendAllLines(filePath, new[] { line });
        }


        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nCourse: {Course}\nCreator: {Creator}\nDate of Creation: {DateOfCreation.ToString(DATEFORMAT)}\nDate of Change: {DateOfChange.ToString(DATEFORMAT)}\nExpiration Date: {ExpirationDate.ToString(DATEFORMAT)}";
        }

        public static List<Notification> ParseFromFile(string filePath)
        {
            List<Notification> notifications = new List<Notification>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(DEL);

                    string name = values[0];
                    string description = values[1];
                    Course course = (Course)Enum.Parse(typeof(Course), values[2]);
                    string creatorName = values[3];
                    DateTime dateOfCreation = DateTime.ParseExact(values[4], DATEFORMAT);
                    DateTime dateOfChange = DateTime.ParseExact(values[5], DATEFORMAT, CultureInfo.InvariantCulture);
                    DateTime expirationDate = DateTime.ParseExact(values[6], DATEFORMAT, CultureInfo.InvariantCulture);

                    Person creator = new Person(creatorName);
                    Notification notification = new Notification(name, description, course, creator, expirationDate);
                    notification.DateOfCreation = dateOfCreation;
                    notification.DateOfChange = dateOfChange;

                    notifications.Add(notification);
                }
            }

            return notifications;
        }

    }
}
