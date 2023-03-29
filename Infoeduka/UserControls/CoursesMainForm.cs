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
            flpAllLecturers.WrapContents = false;
            flpLecturersOnCourse.WrapContents = false;

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
                lbl.MouseMove += Lbl_MouseMove;
                flpAllLecturers.Controls.Add(lbl);
            }

        }
       


        //metoda za stvaranje nove labele u koje će se dodavati osobe
        public  Label GetPersonLabel(Person o, Size size)
        {
            var label = new Label
            {
                Text = $"{o.FirstName} {o.LastName}",
                AutoSize = false,
                Size = size,
                BackColor = Color.FromArgb(11, 7, 17),
                ForeColor = Color.WhiteSmoke,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(3),
                    
                Tag = o.Id
            };

            label.MouseEnter += (sender, e) =>
            {
                // Promijeni boju pozadine kada miš uđe na labelu
                label.BackColor = Color.FromArgb(183, 35, 69);
            };

            label.MouseLeave += (sender, e) =>
            {
                // Vrati početnu boju pozadine kada miš izađe sa labele
                label.BackColor = Color.FromArgb(11,7,17);
            };
            return label;
        }

        //Metoda koja iz flow layout pnaela vraća listu predavača 
        private List<Person> GetLecturersFromLecturersOnCourse()
        {
            List<Person> lecturers = new();

            IDictionary<int, Person> persons = _dataManager.GetPersonsDictionary();

            // prolazak kroz sve kontrole u FlowLayoutPanelu
            foreach (Control control in flpLecturersOnCourse.Controls)
            {
                // provjera da li je kontrola tipa Label
                if (control is Label label)
                {
                    // dohvaćanje podataka o Person objektu iz teksta labele

                    int personId = Convert.ToInt32(label.Tag);
                   
                    foreach (var key in persons.Keys)
                    {
                        if (key == personId)
                        {
                            lecturers.Add(persons[personId]);
                        }
                    }

                }
            }

            return lecturers;
        }


        // Metoda koja se poziva kada korisnik pomjera mišem preko labele - za drag and drop
        private void Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            // Konverzija sender-a u Label tip.
            Label lbl = sender as Label;
            // Provjera da li je lbl null, u slučaju da sender nije tipa Label.
            // Ako je lbl null, DoDragDrop() se neće pozvati.
            lbl?.DoDragDrop(lbl, DragDropEffects.Move);
        }


        //Eventi za drag and drop
        private void FlpLecturersOnCourse_DragDrop(object sender, DragEventArgs e)
        {
            var addedlabel = e.Data.GetData(typeof(Label)) as Label;

            // Provjerite postoji li labela s istim imenom
            string labelTag = addedlabel.Tag.ToString();
            bool labelAlreadyExists = false;
            foreach (Control control in flpLecturersOnCourse.Controls)
            {
                if (control is Label && control.Tag.ToString() == labelTag)
                {
                    labelAlreadyExists = true;
                    break;
                }
            }

            // Ako labela već postoji, ne dodajte je ponovno
            if (labelAlreadyExists)
            {
                return;
            }

            Label draggedLabel = e.Data?.GetData(typeof(Label)) as Label;

            Label newLabel = new Label();
            newLabel.Text = draggedLabel.Text;
            newLabel.Font = draggedLabel.Font;
            newLabel.BackColor = draggedLabel.BackColor;
            newLabel.ForeColor = draggedLabel.ForeColor;
            newLabel.Size = draggedLabel.Size;
            newLabel.TextAlign = draggedLabel.TextAlign;
            newLabel.Tag = draggedLabel.Tag;
            newLabel.Margin = draggedLabel.Margin;

        
                      

            Point mouseLocation = MousePosition;
            mouseLocation = flpLecturersOnCourse.PointToClient(mouseLocation);
            newLabel.Location = mouseLocation;

            flpLecturersOnCourse.Controls.Add(newLabel);


        }
             

        private void FlpLecturersOnCourse_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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

        //metoda za brisanje unesenog iz forme
        private void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                flpLecturersOnCourse.Controls.Clear();

            }
        }

        //Metoda za gumb spremi
        private void BtnSave_Click(object sender, EventArgs e)
        {

            var name = tbCourseName.Text;
            var code = tbCode.Text;
            var ects = int.Parse(tbEcts.Text);
            List<Person> lecturers = GetLecturersFromLecturersOnCourse();

            // kreirajte novog Person objekta
            Course newCourse = new Course(name, code, ects, lecturers);
            try
            {
                // dodajte novog Person objekta u dictionary u DataManager klasi
                _dataManager.AddNewCourseToDictionary(newCourse);

                // obavijestite korisnika da su podaci spremljeni
                ClearForm();
                MessageBox.Show("Uspješno spremljeno.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Došlo je do greške, podaci nisu spremljeni" + ex.Message);
            }

        }
    }
}
