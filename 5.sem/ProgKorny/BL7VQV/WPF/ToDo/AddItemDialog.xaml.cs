using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDo
{
    public partial class AddItemDialog : Window
    {
        private ToDoController toDoController;

        public AddItemDialog()
        {
            InitializeComponent();
        }

        internal void Initialize(ToDoController controller)
        {
            toDoController = controller;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string[] result = ProcessResult();

            if (result != null && result.Length == 4)
            {
                string title = result[0];
                string category = result[1];
                string date = result[2];
                string time = result[3];

                try
                {
                    DateTime dateTime = DateTime.ParseExact(date + " " + time, "yyyy-MM-dd HH:mm", null);

                    string newItem = $"Cím: {title}, Kategória: {category}, Dátum: {date}, Idő: {time}";
                    toDoController.AddItemToList(newItem);

                    CloseDialog();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás dátum vagy idő formátum!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            string[] result = ProcessResult();

            if (result != null && result.Length == 4)
            {
                string title = result[0];
                string category = result[1];
                string date = result[2];
                string time = result[3];

                try
                {
                    DateTime dateTime = DateTime.ParseExact(date + " " + time, "yyyy-MM-dd HH:mm", null);
                    
                    string newItem = $"Cím: {title}, Kategória: {category}, Dátum: {date}, Idő: {time}";
                    toDoController.AddItemToList(newItem);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás dátum vagy idő formátum!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CloseDialog();
        }

        private string[] ProcessResult()
        {
            string title = TitleField.Text;
            string category = CategoryField.Text;
            string date = DatePicker.SelectedDate?.ToString("yyyy-MM-dd");
            string time = TimeField.Text;

            if (title == "" || category == "" || date == "" || time == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }

            return new string[] { title, category, date, time };
        }

        private void CloseDialog()
        {
            this.Close();
        }

        private void TitleField_TextChanged(object sender, TextChangedEventArgs e)
        {
            var  newText = ((TextBox)sender).Text;
        }

        private void CategoryField_TextChanged(object sender, TextChangedEventArgs e)
        {
            var newCategory = ((TextBox)sender).Text;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var newDate = ((DatePicker)sender).SelectedDate;
        }

        private void TimeField_TextChanged(object sender, TextChangedEventArgs e)
        {
            var newTime = ((TextBox)sender).Text;
        }

        
    }
}
