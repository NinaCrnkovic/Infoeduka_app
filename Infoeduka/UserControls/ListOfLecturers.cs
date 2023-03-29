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
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();
            
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
            string[] rowData =
            {
                person.FirstName,
                person.LastName,
                person.Email,
                person.Password,
                person.IsAdmin ? "Administrator" : "Predavač"
            };
            ListViewItem row = new ListViewItem(rowData);
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
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Ime", Width = 150 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Prezime", Width = 150 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Email", Width = 250 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Password", Width = 190 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Tip korisnika", Width = 120 });
        }
    }
}
