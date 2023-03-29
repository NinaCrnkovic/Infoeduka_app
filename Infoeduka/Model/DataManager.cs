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
        IDictionary<int, Person> personsDictionary = new Dictionary<int, Person>();
        IDictionary<int, Course> coursesDictionary = new Dictionary<int, Course>();

        //metoda za napuniti osobe u dictionary iz fajle
        public void LoadPersonsToDictionary()
        {

            try
            {
                IList<Person> persons = repo.GetPersons();
                FillPersonsDictionary(persons);
            }
            catch (Exception e)
            {
                MessageBox.Show($"load person to dic" +e.Message);
            }
        }


        //metoda za napuniti kolegije u dictionary iz fajle
        public IDictionary<int, Course> LoadCoursesToDictionary()
        {
            try
            {
                IList<Course> courses = repo.GetCourses();
                FillCoursesDictionary(courses);
            }
            catch (Exception e)
            {
                MessageBox.Show($"load courses to dic" + e.Message);
            }
            return coursesDictionary;
        }

        //metoda za dohvati dicitionarya osoba
        public IDictionary<int, Person> GetPersonsDictionary()
        {
            return personsDictionary;
        }
        //metoda za dohvati dicitionarya kolegija
        public IDictionary<int, Course> GetCoursesDictionary()
        {
            return coursesDictionary;
        }

        //metoda za punjenje dicitonaria iz liste
        private void FillCoursesDictionary(IList<Course> courses)
        {
            foreach (Course course in courses)
            {
                try
                {
                    coursesDictionary.Add(course.Id, course);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"fill courses dic" + e.Message);
                }
            }
        }

        //metoda za punjenje dicitonaria iz liste
        private void FillPersonsDictionary(IList<Person> persons)
        {
            foreach (Person person in persons)
            {
                try
                {
                    personsDictionary.Add(person.Id, person);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"fill person dic" + e.Message);
                }
            }
        }

        //doavanje osobe u dictyonary
        public void AddNewPersonToDictionary(Person newPerson)
        {


            // dodajte novog Person objekta u dictionary
            personsDictionary.Add(newPerson.Id, newPerson);

        }

        public void DeletePersonFromDictionary(int id)
        {
            personsDictionary.Remove(id);
        }

        public void DeleteCourseFromDictionary(int id)
        {
            coursesDictionary.Remove(id);
        }

        public void UpdatePersonFromDictionari(Person updatedPerson)
        {
            //provjeravamo da li osoba postoji u dictionaryu
            if (personsDictionary.ContainsKey(updatedPerson.Id))
            {
                //dohvaćamo osobu
                Person person = personsDictionary[updatedPerson.Id];
                //postavljamo nove vrijednosti
                person.FirstName = updatedPerson.FirstName;
                person.LastName = updatedPerson.LastName;
                person.Email = updatedPerson.Email;
                person.Password = updatedPerson.Password;
                person.IsAdmin = updatedPerson.IsAdmin;

                //update osobe
                personsDictionary[updatedPerson.Id] = person;
            }
            else
            {
                // ako osoba s ID-om ne postoji u rječniku, izbacite iznimku ili 
                // napravite neku drugu vrstu manipulacije podacima
                throw new KeyNotFoundException("Osoba s ID-om " + updatedPerson.Id + " ne postoji u rječniku.");
            }

        }

        //doavanje kolegija u dictyonary
        public void AddNewCourseToDictionary(Course newCourse)
        {


            // dodajte novog Course objekta u dictionary
            coursesDictionary.Add(newCourse.Id, newCourse);

        }

        public void SaveDataForPersonsAndCourses(IList<Person> persons, IList<Course> courses)
        {
            try
            {
                repo.SavePersonData(persons);
                repo.SaveCourseData(courses);
            }
            catch (Exception e)
            {
                MessageBox.Show($"save person and course"+e.Message);
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
                MessageBox.Show($"save all" +e.Message);
            }
        }
    }
}
