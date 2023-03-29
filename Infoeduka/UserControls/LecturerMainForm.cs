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
    public partial class LecturerMainForm : UserControl
    {
        //u pozivu kreiranja ove komponente će se poslati data manager i postaviti ćemo ga ovdje u konstruktoru kako bi mogli pristupiti metodama
        private readonly DataManager _dataManager;
        private string callingButton;
        private Person personEdit;
        public LecturerMainForm(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            this.callingButton = callingButton;
            InitializeComponent();
        }

        // Konstruktor s dodatnim parametrom 
        public LecturerMainForm(DataManager dataManager, string callingButton, Person personEdit) : this(dataManager, callingButton)
        {
            this.personEdit = personEdit;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var email = tbEmail.Text;
            var password = tbPassword.Text;
            var isAdmin = GetChecked();

            // kreirajte novog Person objekta
            
           
                if (callingButton == "btnAddNewLecturer")
                {
                    Person newPerson = new Person(firstName, lastName, email, password, isAdmin);
                    try
                    {
                    // dodajte novog Person objekta u dictionary u DataManager klasi
                    _dataManager.AddNewPersonToDictionary(newPerson);

                    // obavijestite korisnika da su podaci spremljeni
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    ClearForm();
                    }
                    catch (Exception ex)
                    {

                     CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                    }   
                }
                else if (callingButton == "btnEditLecturer")
                {
                    personEdit.FirstName = firstName;
                    personEdit.LastName = lastName;
                    personEdit.Email = email;
                    personEdit.Password = password;
                    personEdit.IsAdmin = isAdmin;
                    try
                    {
                    _dataManager.UpdatePersonFromDictionari(personEdit);
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    Dispose();
                    }
                    catch (Exception ex)
                    {

                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                }

                
                               
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
                if (personEdit != null)
                {
                    tbFirstName.Text = personEdit.FirstName;
                    tbLastName.Text = personEdit.LastName;
                    tbEmail.Text = personEdit.Email;
                    tbPassword.Text = personEdit.Password;

                    if (personEdit.IsAdmin)
                    {
                        rbtnAdmin.Checked = true;
                    }
                    else
                    {
                        rbtnLecturer.Checked = true;
                    }
                }
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
