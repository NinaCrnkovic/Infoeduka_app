using Utilities;

namespace Infoeduka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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


        //Gumbi footer
        //akcije na gumbima u footeru - linkovi na stranice

        private void LbAlgebraLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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



        //prikazuje user controler forme
        private void ShowUserControlsForm(UserControl form)
        {
            if (form.Visible == false)
            {
                //hide metoda zatvara prijašnjiu otvorenu formu
                //HideUserControlsForm();
                form.Visible = true;
            }
            else
            {

                form.Visible = false;
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