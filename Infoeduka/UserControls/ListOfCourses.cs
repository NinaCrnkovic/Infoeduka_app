using Infoeduka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoeduka.UserControls
{
    public partial class ListOfCourses : UserControl
    {
        private readonly DataManager _dataManager;
        private string callingButton;
        public ListOfCourses(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            this.callingButton = callingButton;
            InitializeComponent();
        }

        private void ListOfCourses_Load(object sender, EventArgs e)
        {
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();

        }
        //metoda za prikaz podataka o osobama
        private void ShowData()
        {
            List<Course> list = LoadData();
            foreach (var item in list)
            {
                AddListViewRow(item);
            }

        }
        //metoda za punjenje liste iz dictionarya osoba
        private List<Course> LoadData()
        {
            IDictionary<int, Course> courses = _dataManager.GetCoursesDictionary();
            List<Course> list = new List<Course>();
            foreach (var course in courses.Values)
            {
                list.Add(course);
            }

            return list;
        }

        private void AddListViewRow(Course course)
        {
            string[] lecturers = course.Lecturers.Select(l => $"{l.FirstName} {l.LastName}").ToArray();
            string[] rowData =
            {
                course.Name,
                course.Code,
                course.Ects.ToString(),
                string.Join(", ", lecturers)


            };
            ListViewItem row = new ListViewItem(rowData);
            lvCourses.Items.Add(row);
        }
        //postavljanje view propertisa na listi
        private void SetListViewProperties()
        {
            lvCourses.GridLines = true;
            lvCourses.FullRowSelect = true;
        
            lvCourses.MultiSelect = false;
        }
        //definiramo kako će nam izgledati hederi da stupcima
        private void DefineListViewColumnHeaders()
        {
            lvCourses.Columns.Add(new ColumnHeader { Text = "Naziv", Width = 300 });
            lvCourses.Columns.Add(new ColumnHeader { Text = "Šifra", Width = 80 });
            lvCourses.Columns.Add(new ColumnHeader { Text = "Br.ECTS bodova", Width = 150 });
            lvCourses.Columns.Add(new ColumnHeader { Text = "Predavači", Width = 650 });

        }
    }


}

