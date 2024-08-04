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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tanárként szeretnél regisztrálni?", "Regisztráció típusa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Tanárként
                Register registerForm = new Register(true);
                registerForm.Show();
            }
            else
            {
                //Diákként
                Register registerForm = new Register(false);
                registerForm.Show();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
