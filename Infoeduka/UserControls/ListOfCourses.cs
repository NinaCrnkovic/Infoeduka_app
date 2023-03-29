using Infoeduka.CustomDesign;
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
            DefineLabelText();
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();
            lvCourses.MouseClick += lvCourses_MouseClick;

        }

        private void lvCourses_MouseClick(object sender, MouseEventArgs e)
        {
            var item = lvCourses.GetItemAt(e.X, e.Y);
            if (item != null && e.Button == MouseButtons.Left)
            {
                var subItem = item.GetSubItemAt(e.X, e.Y);
                if (subItem != null && subItem.Text == "Izbriši kolegij")
                {
                    var course = item.Tag as Course;
                    if (course != null)
                    {
                        var lecturerNames = string.Join(", ", course.Lecturers.Select(l => $"{l.FirstName} {l.LastName}"));
                        var result = CustomMessageBox.Show($"Jeste li sigurni da želite izbrisati kolegij Šifra: {course.Code}, {course.Name}, {course.Ects}, Predavači: {lecturerNames}?", "Upozorenje", MessageBoxButtons.OKCancel);


                        //var result = CustomMessageBox.Show($"Jeste li sigurni da želite izbrisati kolegij Šifra: {course.Code}, {course.Name}, {course.Ects}, Predavači: {course.Lecturers} ?", "Upozorenje", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.Yes)
                        {
                            _dataManager.DeleteCourseFromDictionary(course.Id);
                            lvCourses.Items.Remove(item);
                        }
                    }
                }
            }
        }

        private void DefineLabelText()
        {
            if (callingButton == "btnViewAllCourses")
            {
                lblTitleForCollegeView.Text = "Pregled svih kolegija";

            }
            else if (callingButton == "btnDeleteCourse")
            {
                lblTitleForCollegeView.Text = "Brisanje kolegija";
            }
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
            string[] rowData = { };
            
            if (callingButton == "btnViewAllCourses")
            {
                rowData = new string[]
                {
                course.Code,
                course.Name,
                course.Ects.ToString(),
                string.Join(", ", lecturers)
                };

            }
            else if (callingButton == "btnDeleteCourse")
            {
                rowData = new string[]
                {
                course.Code,
                course.Name,
                course.Ects.ToString(),
                //string.Join(", ", lecturers),
                "Izbriši kolegij"
                };
            }

            ListViewItem row = new ListViewItem(rowData);
            row.Tag = course;
            // Postavljanje boje teksta za ćeliju sa natpisom "Delete"
            if (rowData.Contains("Izbriši kolegij"))
            {
                row.UseItemStyleForSubItems = false;
                row.SubItems[rowData.Length - 1].ForeColor = Color.Red;
            }

           
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
            if (callingButton == "btnViewAllCourses")
            {
                lvCourses.Columns.Add(new ColumnHeader { Text = "Šifra", Width = 80 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "Naziv", Width = 300 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "ECTS", Width = 50 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "Predavači", Width = 650 });


            }
            else if (callingButton == "btnDeleteCourse")
            {
                lvCourses.Columns.Add(new ColumnHeader { Text = "Šifra", Width = 80 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "Naziv", Width = 500 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "ECTS", Width = 50 });
                //lvCourses.Columns.Add(new ColumnHeader { Text = "Predavači", Width = 450 });
                lvCourses.Columns.Add(new ColumnHeader { Text = "Brisanje kolegija", Width = 228 });

            }

        }
    }


}

