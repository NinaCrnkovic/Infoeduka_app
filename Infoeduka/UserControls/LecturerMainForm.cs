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
    public partial class LecturerMainForm : UserControl
    {
        //u pozivu kreiranja ove komponente će se poslati data manager i postaviti ćemo ga ovdje u konstruktoru kako bi mogli pristupiti metodama
        private readonly DataManager _dataManager;
        private string callingButton;
        public LecturerMainForm(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            this.callingButton = callingButton;
            
            InitializeComponent();
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var email = tbEmail.Text;
            var password = tbPassword.Text;
            var isAdmin = GetChecked();

            // kreirajte novog Person objekta
            Person newPerson = new Person( firstName, lastName, email, password, isAdmin);
            try
            {
                // dodajte novog Person objekta u dictionary u DataManager klasi
                _dataManager.AddNewPersonToDictionary(newPerson);


                // obavijestite korisnika da su podaci spremljeni
                ClearForm();
                MessageBox.Show("Podaci su spremljeni");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message);
            }
         
        }

        private bool GetChecked()
        {
            if (rbtnAdmin.Checked)
            {
                return true;
            }
            return false;

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
            // Brišemo tekstualna polja unutar kontrola gbLecturers
            foreach (Control control in gbLecturer.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
                  
          
            rbtnAdmin.Checked = false;
            rbtnLecturer.Checked = false;
                    
                   
            

        }
    }
}
