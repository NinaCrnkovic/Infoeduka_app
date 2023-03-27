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
using Utilities;

namespace Infoeduka.UserControls
{
 
    public partial class LoginForm : UserControl
    {
        //definiranje master admina
        private readonly Person masterAdmin = new Person()
        {
            Email = "master@admin.com",
            FirstName = "Master",
            LastName = "Admin",
            Password = "1234",
            IsAdmin = true
        };

        //definiranje tekstualnih polja
        string username = "";
        string password = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            username = tbEmail.Text;
            //Utility.IsUsernameValid(username);

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            password = tbPassword.Text;
            tbPassword.PasswordChar = '*';


        }

        private void BtnMainNotifications_Click(object sender, EventArgs e)
        {
            if (password != masterAdmin.Password)
            {
                MessageBox.Show($"Pogrešno unesen password {password}", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (username != masterAdmin.Email)
            {
                MessageBox.Show($"Pogrešno uneseno korisničko ime {username}", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (username == masterAdmin.Email && password == masterAdmin.Password)
            {
                this.Visible = false;
            }
        }
    }
}
