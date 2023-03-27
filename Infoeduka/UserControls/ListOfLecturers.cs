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

        private void ShowData()
        {
            IDictionary <string, Person> persons = _dataManager.GetPersonsDictionary();
            List<Person> list = new List<Person>();
            foreach(var person in persons.Values)
            {
                list.Add(person);
            }
            foreach (var l in list)
            {
                AddListViewRow(l);
            }
            
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
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Ime", Width = 100 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Prezime", Width = 100 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Email", Width = 100 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Pasword", Width = 100 });
            lvLecturers.Columns.Add(new ColumnHeader { Text = "Tip korisnika", Width = 100 });
        }
    }
}
