using Infoeduka.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Model
{
    public class DataManager
    {
        private IRepo repo = RepoFactory.GetRepo();
        IDictionary<string, Person> personsDictionary = new Dictionary<string, Person>();
        IDictionary<string, Course> coursesDictionary = new Dictionary<string, Course>();
        public void LoadPersonsToDictionary()
        {

            try
            {
                IList<Person> persons = repo.GetPersons();
                FillPersonsDictionary(persons);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public IDictionary<string, Course> LoadCoursesToDictionary()
        {
            try
            {
                IList<Course> courses = repo.GetCourses();
                FillCoursesDictionary(courses);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return coursesDictionary;
        }

        private void FillCoursesDictionary(IList<Course> courses)
        {
            foreach (Course course in courses)
            {
                try
                {
                    coursesDictionary.Add(course.Id.ToString(), course);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void FillPersonsDictionary(IList<Person> persons)
        {
            foreach (Person person in persons)
            {
                try
                {
                    personsDictionary.Add(person.Id.ToString(), person);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void AddNewPersonToDictionary(Person newPerson)
        {


            // dodajte novog Person objekta u dictionary
            personsDictionary.Add(newPerson.Id.ToString(), newPerson);

            // spremite novu dictionary u DataManager klasi
            // manager.SaveDataForPersons(personsDictionary.Values.ToList());
        }

        public void SaveDataForPersonsAndCourses(IList<Person> persons, IList<Course> courses)
        {
            try
            {
                repo.SaveData(persons, courses);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //metaoda koja sprema sve podatke prije zatvaranja aplikacije
        public void SaveAllDataInFile()
        {
            try
            {
                IList<Person> persons = personsDictionary.Values.ToList();
                IList<Course> courses = coursesDictionary.Values.ToList();
                SaveDataForPersonsAndCourses(persons, courses);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
