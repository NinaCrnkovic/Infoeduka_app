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
using static System.Windows.Forms.ListViewItem;

namespace Infoeduka.UserControls
{
    public partial class ListOfLecturers : UserControl
    {
        private readonly DataManager _dataManager;
        private string callingButton;
        public ListOfLecturers(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            this.callingButton = callingButton;
            InitializeComponent();
        }

        private void ListOfLecturers_Load(object sender, EventArgs e)
        {
            DefineLabelText();
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();
            lvLecturers.MouseClick += lvLecturers_MouseClick;

        }

        private void DefineLabelText()
        {
            if(callingButton == "btnViewAllLecturers")
            {
                lblTitleForListOfLecturers.Text = "Pregled svih predavača";
            }
            else if (callingButton == "btnDeleteLecturer")
            {
                lblTitleForListOfLecturers.Text = "Brisanje predavača";
            }
        }

        private void lvLecturers_MouseClick(object sender, MouseEventArgs e)
        {
            var item = lvLecturers.GetItemAt(e.X, e.Y);
            if (item != null && e.Button == MouseButtons.Left)
            {
                var subItem = item.GetSubItemAt(e.X, e.Y);
                if (subItem != null && subItem.Text == "Izbriši predavača")
                {
                    var person = item.Tag as Person;
                    if (person != null)
                    {
                        // prikaži message box sa upozorenjem i zatraži korisničku potvrdu
                        var result = MessageBox.Show($"Jeste li sigurni da želite izbrisati predavača {person.FirstName} {person.LastName}, {person.Email}, password: {person.Password}?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _dataManager.DeletePersonFromDictionary(person.Id);
                            lvLecturers.Items.Remove(item);
                        }
                    }
                }
            }
        }

        //metoda za prikaz podataka o osobama
        private void ShowData()
        {
            List<Person> list = LoadData();
            foreach (var item in list)
            {
                AddListViewRow(item);
            }

        }
        //metoda za punjenje liste iz dictionarya osoba
        private List<Person> LoadData()
        {
            IDictionary<int, Person> persons = _dataManager.GetPersonsDictionary();
            List<Person> list = new List<Person>();
            foreach (var person in persons.Values)
            {
                list.Add(person);
            }

            return list;
        }

        private void AddListViewRow(Person person)
        {
            string[] rowData = { };
            if (callingButton == "btnViewAllLecturers")
            {
                rowData = new string[]
                {
                person.FirstName,
                person.LastName,
                person.Email,
                person.Password,
                person.IsAdmin ? "Administrator" : "Predavač"
                };
            }
            else if (callingButton == "btnDeleteLecturer")
            {
                rowData = new string[]
                {
                person.FirstName,
                person.LastName,
                person.Email,
                //person.Password,
                //person.IsAdmin ? "Administrator" : "Predavač",
                "Izbriši predavača"
                };
              
            }
            ListViewItem row = new ListViewItem(rowData);
            row.Tag = person;
            // Postavljanje boje teksta za ćeliju sa natpisom "Delete"
            if (rowData.Contains("Izbriši predavača"))
            {
                row.UseItemStyleForSubItems = false;
                row.SubItems[rowData.Length - 1].ForeColor = Color.Red;
            }

            lvLecturers.Items.Add(row);
        }
        


        //postavljanje view propertisa na listi
        private void SetListViewProperties()
        {
            lvLecturers.GridLines = true;
            lvLecturers.FullRowSelect = true;
            lvLecturers.MultiSelect = false;
        }
        //definiramo kako će nam izgledati hederi da stupcima
        private void DefineListViewColumnHeaders()
        {
            if (callingButton == "btnViewAllLecturers")
            {
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Ime", Width = 150 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Prezime", Width = 200 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Email", Width = 250 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Password", Width = 120 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Tip korisnika", Width = 140 });
            }
            else if (callingButton == "btnDeleteLecturer")
            {
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Ime", Width = 150 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Prezime", Width = 250 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Email", Width = 250 });
                //lvLecturers.Columns.Add(new ColumnHeader { Text = "Password", Width = 190 });
                //lvLecturers.Columns.Add(new ColumnHeader { Text = "Tip korisnika", Width = 140 });
                lvLecturers.Columns.Add(new ColumnHeader { Text = "Brisanje predavača", Width = 250 });
            }



        }
    }
}
