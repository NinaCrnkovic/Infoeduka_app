using Infoeduka.Model;
using Infoeduka.UserControls;
using Utilities;

namespace Infoeduka
{
    public partial class MainForm : Form
    {
        private DataManager dataManager = new DataManager();
        public MainForm()
        {
            
            InitializeComponent();
            SetPanelVisibilityToFalse();
        }
        //ponašanje tijekom pokretanja frome
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataManager.LoadPersonsToDictionary();
            dataManager.LoadCoursesToDictionary();
        }
        //ponašanje tijekom zatvaranja forme
        private void SaveAllOnClosing(object sender, FormClosingEventArgs e)
        {
            dataManager.SaveAllDataInFile();
        }

        //glavni gumbi - koji otvaraju padajuæi izbornik
        private void MainButtonsForDropDownMenu_Click(object sender, EventArgs e)
        {
            Button? mainButton = sender as Button;
            if (mainButton is null)
            {
                return;
            }
            switch (mainButton.Name)
            {
                case "btnMainNotifications":
                    ShowDropDownPanel(pnlNotificationsDropDown);
                    break;
                case "btnMainCourse":
                    ShowDropDownPanel(pnlCourseDropDown);
                    break;
                case "btnMainLecturer":
                    ShowDropDownPanel(pnlLecturerDropDown);
                    break;

            }
        }

        //Gumbi u padajuæem izborniku
        private void ButtonsInDropDownMenu_Click(object sender, EventArgs e)
        {
            Button? dropdownButton = sender as Button;
            if (dropdownButton is null)
            {
                return;
            }
            switch (dropdownButton.Name)
            {
                case "btnViewAllNotifications":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;
                case "btnAddNewNotification":
                    NotificationMainForm formAddNotification = new();
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddNotification);
                    break;
                case "btnEditNotification":
                    NotificationMainForm formEditNotification = new();
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditNotification);
                    break;
                case "btnDeleteNotification":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;
                case "btnViewAllCourses":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;
                case "btnAddNewCourse":
                    CoursesMainForm formAddCourse = new();
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddCourse);
                    break;
                case "btnEditCourse":
                    CoursesMainForm formEditCourse = new();
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditCourse);
                    break;
                case "btnDeleteCourse":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;
                case "btnViewAllLecturers":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;
                case "btnAddNewLecturer":
                    LecturerMainForm formAddLecturer = new LecturerMainForm(dataManager, "btnAddNewLecturer");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddLecturer);
                    break;
                case "btnEditLecturer":
                    LecturerMainForm formEditLecturer = new(dataManager, "btnEditLecturer");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditLecturer);
                    break;
                case "btnDeleteLecturer":
                    pnlHolderForOtherPanels.Controls.Clear();
                    break;

            }
        }


        //Gumbi footer
        //akcije na gumbima u footeru - linkovi na stranice

        private void LbAlgebraLink_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Utility.VisitLink("https://www.algebra.hr/");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void LinkItems_Click(object sender, EventArgs e)
        {
            PictureBox? linkItem = sender as PictureBox;
            if (linkItem is null)
            {
                return;
            }
            switch (linkItem.Name)
            {
                case "pbTikTok":
                    Utility.VisitLink("https://www.tiktok.com/@algebrauniversity");
                    break;
                case "pbLinkedin":
                    Utility.VisitLink("https://www.linkedin.com/company/algebra/");
                    break;
                case "pbFacebook":
                    Utility.VisitLink("https://web.facebook.com/racunarstvo?_rdc=1&_rdr");
                    break;
                case "pbInstagram":
                    Utility.VisitLink("https://www.instagram.com/algebra_university_college/");
                    break;
                case "pbYouTube":
                    Utility.VisitLink("https://www.youtube.com/channel/UCWIWCcDw_k2-BP9JnbryIyg");
                    break;
            }
        }



    



        //postavljamo visibility na panelima koji glume drop down i ukojima su ostali gumbi na false 
        private void SetPanelVisibilityToFalse()
        {

            pnlCourseDropDown.Visible = false;
            pnlNotificationsDropDown.Visible = false;
            pnlLecturerDropDown.Visible = false;
        }



        //metoda za skrivanje panela koji glume drop down
        private void HideDropDownPanel()
        {
            if (pnlCourseDropDown.Visible)
            {
                pnlCourseDropDown.Visible = false;
            }
            if (pnlNotificationsDropDown.Visible)
            {
                pnlNotificationsDropDown.Visible = false;
            }
            if (pnlLecturerDropDown.Visible)
            {
                pnlLecturerDropDown.Visible = false;
            }

        }

        //metoda za pokazivanje panela koji glume drop down
        private void ShowDropDownPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                //hide metoda zatvara prijašnji otvoreni drop down kada klikenemo na slijedeæi
                HideDropDownPanel();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

    
    }
}