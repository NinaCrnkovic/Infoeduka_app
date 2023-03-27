using Infoeduka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Dal
{
    public interface IRepo
    {
        public void SaveData(IList<Person> persons, IList<Course> course);

        public IList<Person> GetPersons();
        public IList<Course> GetCourses();
    }
}
