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
