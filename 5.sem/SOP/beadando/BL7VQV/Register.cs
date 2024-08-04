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
    public partial class Register : Form
    {
        private bool teacher = false;
        public Register(bool v)
        {
            InitializeComponent();
        }

        private void Teacher_CheckedChanged(object sender, EventArgs e)
        {
            if (Teacher.Checked)
            {
                teacher = true;
            }
            else
            {
                teacher = false;
            }
        }


        private async void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string firstname = firstnameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            string password = passwordTextBox.Text;
            bool isTeacher = Teacher.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValidData = ValidateUserData(username, firstname, lastname, password);
            if (!isValidData)
            {
                MessageBox.Show("Hibás adatok!", "Hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registrationSuccess= await CallRegistrationAPI(username, password, firstname, lastname, isTeacher);
        
            if (registrationSuccess)
            {
                MessageBox.Show("Sikeres regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sikertelen regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
        }

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {
            string firstname = firstnameTextBox.Text;
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            string lastname = lastnameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
        }


        private bool ValidateUserData(string username, string password, string firstName, string lastName)
        {
            const int MIN_PASSWORD_LENGTH = 6;
            if(password.Length < MIN_PASSWORD_LENGTH)
            {
                MessageBox.Show($"A jelszónak legalább {MIN_PASSWORD_LENGTH} karakter hosszúnak kell lennie!", "Jelszó hossza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

            //special karakter ellenőrzés

            return true;
        }

        private async Task<bool> CallRegistrationAPI(string username, string password, string firstName, string lastName, bool isTeacher)
        {


            await Task.Delay(1000);
            return true;
        }
    }
}
