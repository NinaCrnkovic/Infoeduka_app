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
    public partial class ListOfNotifications : UserControl
    {
        private readonly DataManager _dataManager;
        private string _callingButton;
        private Panel _pnlHolderForOtherPanels;
        public ListOfNotifications(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
            InitializeComponent();
        }


        public ListOfNotifications(DataManager dataManager, string callingButton, Panel holderPanel) : this(dataManager, callingButton)
        {
            _pnlHolderForOtherPanels = holderPanel;

        }

        private void ListOfNotifications_Load(object sender, EventArgs e)
        {
            if (_callingButton == "")
            {
                LoadCurrentNotifications();
            }
            else if (_callingButton == "btnViewAllNotifications")
            {
                LoadAllNotifications();
            }
           
        }

        private void LoadCurrentNotifications()
        {
            IDictionary<int, Notification> notificationDictionary = _dataManager.GetNotificationDictionary();
            // sortiranje obavijesti po datumu od najnovije
            var sortedNotifications = notificationDictionary.Values.OrderByDescending(n => n.DateOfCreation);

            foreach (Notification notification in notificationDictionary.Values)
            {
                //provjerava da li je obavijest istekla, ako je ne prikazuje se
                if (notification.ExpirationDate <= DateTime.Today)
                {
                    continue;
                }
                NotificationPanel panel = new NotificationPanel();

                // Dohvatite HeaderPanel unutar panela
                //Control headerPanel = panel.Controls.Find("HeaderPanel", true).FirstOrDefault();

                // Pronađite labelu lblTitle unutar HeaderPanela
                Label foundLabel = panel.Controls.Find("lblTitle", true).FirstOrDefault() as Label;
                foundLabel.Text = notification.Name;

                // Pronađite labelu lblLecturer unutar panela
                Label lecturerLabel = panel.Controls.Find("lblLecturer", true).FirstOrDefault() as Label;
                lecturerLabel.Text = $"{notification.Creator.FirstName} {notification.Creator.LastName}";

                // Pronađite labelu lblCreated unutar panela
                Label createdLabel = panel.Controls.Find("lblCreated", true).FirstOrDefault() as Label;
                createdLabel.Text = $"Kreirano:\n{notification.DateOfCreation.ToString()}";

                // Pronađite labelu lblChange unutar panela
                Label changeLabel = panel.Controls.Find("lblChange", true).FirstOrDefault() as Label;
                if (notification.DateOfChange > notification.DateOfCreation)
                {
                    
                    changeLabel.Text = $"Promijenjeno:\n{notification.DateOfChange.ToString()}";
                }
                

                // Pronađite textbox tbDescription unutar panela
                TextBox descriptionTextBox = panel.Controls.Find("tbDescription", true).FirstOrDefault() as TextBox;
                descriptionTextBox.Text = notification.Description;

                flpHolderForNotifications.Controls.Add(panel);
            }
        }


        private void LoadAllNotifications()
        {
            IDictionary<int, Notification> notificationDictionary = _dataManager.GetNotificationDictionary();
            // sortiranje obavijesti po datumu od najnovije
            var sortedNotifications = notificationDictionary.Values.OrderByDescending(n => n.DateOfCreation);

            foreach (Notification notification in notificationDictionary.Values)
            {
                NotificationPanel panel = new NotificationPanel();

                // Dohvatite HeaderPanel unutar panela
                //Control headerPanel = panel.Controls.Find("HeaderPanel", true).FirstOrDefault();

                // Pronađite labelu lblTitle unutar HeaderPanela
                Label foundLabel = panel.Controls.Find("lblTitle", true).FirstOrDefault() as Label;
                foundLabel.Text = notification.Name;

                // Pronađite labelu lblLecturer unutar panela
                Label lecturerLabel = panel.Controls.Find("lblLecturer", true).FirstOrDefault() as Label;
                lecturerLabel.Text = $"{notification.Creator.FirstName} {notification.Creator.LastName}";

                // Pronađite labelu lblCreated unutar panela
                Label createdLabel = panel.Controls.Find("lblCreated", true).FirstOrDefault() as Label;
                createdLabel.Text = $"Kreirano:\n{notification.DateOfCreation.ToString()}";

                // Pronađite labelu lblChange unutar panela
                Label changeLabel = panel.Controls.Find("lblChange", true).FirstOrDefault() as Label;
                if (notification.DateOfChange > notification.DateOfCreation)
                {

                    changeLabel.Text = $"Promijenjeno:\n{notification.DateOfChange.ToString()}";
                }


                // Pronađite textbox tbDescription unutar panela
                TextBox descriptionTextBox = panel.Controls.Find("tbDescription", true).FirstOrDefault() as TextBox;
                descriptionTextBox.Text = notification.Description;

                flpHolderForNotifications.Controls.Add(panel);
            }
        }


    }
}