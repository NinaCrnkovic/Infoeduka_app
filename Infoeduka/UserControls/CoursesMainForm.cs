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
    public partial class CoursesMainForm : UserControl
    {
        private readonly DataManager _dataManager;
        private string callingButton;
        public CoursesMainForm(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            this.callingButton = callingButton;
            InitializeComponent();
        }

        private void CoursesMainForm_Load(object sender, EventArgs e)
        {
            
            ShowData();
        }

        //metoda za prikaz podataka o osobama
        private void ShowData()
        {
            List<Person> list = LoadData();
            foreach (var item in list)
            {
                Label lbl = GetPersonLabel(item, new Size(flpAllLecturers.Width, 40));
                flpAllLecturers.Controls.Add(lbl);
            }

        }
        //metoda za punjenje liste iz dictionarya osoba
        private List<Person> LoadData()
        {
            IDictionary<string, Person> persons = _dataManager.GetPersonsDictionary();
            List<Person> list = new List<Person>();
            foreach (var person in persons.Values)
            {
                list.Add(person);
            }

            return list;
        }

        public  Label GetPersonLabel(Person o, Size size)
        {
            var label=  new Label
            {
                Text = $"{o.FirstName} {o.LastName}",
                AutoSize = false,
                Size = size,
                BackColor = Color.FromArgb(23, 21, 23),
                ForeColor = Color.WhiteSmoke,
                TextAlign = ContentAlignment.MiddleCenter,
               
                
            };
            label.MouseEnter += (sender, e) =>
            {
                // Promijeni boju pozadine kada miš uđe na labelu
                label.BackColor = Color.FromArgb(183, 35, 69);
            };

            label.MouseLeave += (sender, e) =>
            {
                // Vrati početnu boju pozadine kada miš izađe sa labele
                label.BackColor = Color.FromArgb(23, 21, 23);
            };
            return label;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

         
            var name = tbCourseName.Text;
            var code = tbCode.Text;
            var ects = int.Parse(tbEcts.Text);
        

            // kreirajte novog Person objekta
            Course newCourse = new Course(name, code, ects, new List<Person>());
            try
            {
                // dodajte novog Person objekta u dictionary u DataManager klasi
                _dataManager.AddNewCourseToDictionary(newCourse);


                // obavijestite korisnika da su podaci spremljeni
                ClearForm();
                MessageBox.Show("Podaci su spremljeni");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Došlo je do greške, podaci nisu spremljeni" + ex.Message);
            }

        }

    
        //provjera koji gumb ga zove (za add ili edit)
        private void LecturerMainForm_Load(object sender, EventArgs e)
        {
            if (callingButton == "btnAddNewLecturer")
            {
                ClearForm();

            }
            else if (callingButton == "btnEditLecturer")
            {
                // kod koji se izvršava ako je drugi gumb pozvao ovu formu
            }
        }

        private void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
              
                // Dodajte druge tipove kontrolera i postavite njihove vrijednosti na prazne ili nule, ako je potrebno.
            }
        }

     
    }
}
