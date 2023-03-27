using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Model
{
    public class Person
    {
        private const char DEL = '|';

        public Guid Id { get; private set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        public bool IsAdmin { get; set; } = false;
        public Person()
        {

        }
        public Person(Guid id, string firstName, string lastName, string email, string password, bool isAdmin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        public Person(string firstName, string lastName, string email, string password, bool isAdmin)
        {
            Id = Guid.NewGuid(); ;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }



        public override string ToString() => $"{Id}, {FirstName} {LastName}, {Email}, {Password}, {(IsAdmin ? "Administrator" : "Predavač")}";

        public string FormatForFile()
        => $"{Id}{DEL}{FirstName}{DEL}{LastName}{DEL}{Email}{DEL}{Password}{DEL}{IsAdmin}";


        public static Person ParseFromFile(string line)
        {
            string[] details = line.Split(DEL);

            if (details.Length < 6)
            {
                throw new ArgumentException("Invalid line format: " + line);
            }
            if (!Guid.TryParse(details[0], out Guid id))
            {
                throw new ArgumentException("Invalid ID format: " + details[0]);

            }
            return new Person
            {
                Id = id,
                FirstName = details[1],
                LastName = details[2],
                Email = details[3],
                Password = details[4],
                IsAdmin = bool.Parse(details[5])
            };
        }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   Id.Equals(person.Id) &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName &&
                   Email == person.Email &&
                   Password == person.Password &&
                   IsAdmin == person.IsAdmin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, Email, Password, IsAdmin);
        }



    }
}
