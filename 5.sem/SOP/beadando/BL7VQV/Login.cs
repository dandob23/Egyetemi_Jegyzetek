using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL7VQV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                bool loginSuccessfull = PerformLogin(username, password);

                if (loginSuccessfull)
                {
                    MessageBox.Show("Sikeres bejelentkezés!", "Bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool PerformLogin(string username, string password)
        {
            if (password == "jelszo")
            {
                return true;
            }
            return false;
        }
    }
}
