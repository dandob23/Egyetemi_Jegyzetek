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
    public partial class EditItemDialog : Window
    {
        private ToDoController toDoController;
        private ObservableCollection<string> toDoItems = new ObservableCollection<string>();

        public EditItemDialog()
        {
            InitializeComponent();
        }

        internal void Initialize(ToDoController controller)
        {
            toDoController = controller;
        }

        private void ItemListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemListBox.SelectedItem != null)
            {
                string selectedItem = ItemListBox.SelectedItem.ToString();

                    
            }
        }

        internal void LoadItemsToListBox(ObservableCollection<string> toDoItems)
        {
            ItemListBox.ItemsSource = toDoItems;

            /*
            if (ItemListBox != null)
            {
                ItemListBox.Items.Clear();
                foreach (var item in toDoItems)
                {
                    ItemListBox.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nincs elem kiválasztva!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
        }

        private void TitleField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItemListBox.SelectedItem != null)
            {
                string selectedItem = ItemListBox.SelectedItem.ToString();
                int selectedIndex = ItemListBox.SelectedIndex;

                string[] selectedData = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
                string[] titleData = selectedData[0].Split(new[] { ": " }, StringSplitOptions.None);

                selectedData[0] = $"Cím: {TitleField.Text}";
                ItemListBox.Items[selectedIndex] = string.Join(", ", selectedData);
            }
        }

        private void CategoryField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ItemListBox.SelectedItem != null)
            {
                string selectedItem = ItemListBox.SelectedItem.ToString();
                int selectedIndex = ItemListBox.SelectedIndex;

                string[] selectedData = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
                string[] categoryData = selectedData[1].Split(new[] { ": " }, StringSplitOptions.None);

                selectedData[1] = $"Kategória: {CategoryField.Text}";
                ItemListBox.Items[selectedIndex] = string.Join(", ", selectedData);
            }
        }

        private void DateField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItemListBox.SelectedItem != null)
            {
                string selectedItem = ItemListBox.SelectedItem.ToString();
                int selectedIndex = ItemListBox.SelectedIndex;

                string[] selectedData = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
                string[] dateData = selectedData[2].Split(new[] { ": " }, StringSplitOptions.None);

                DateTime? selectedDate = DatePicker.SelectedDate;
                selectedData[2] = $"Dátum: {selectedDate?.ToString("yyyy-MM-dd")}";
                ItemListBox.Items[selectedIndex] = string.Join(", ", selectedData);
            }
        }

        private void TimeField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItemListBox.SelectedItem != null)
            {
                string selectedItem = ItemListBox.SelectedItem.ToString();
                int selectedIndex = ItemListBox.SelectedIndex;

                string[] selectedData = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
                string[] timeData = selectedData[3].Split(new[] { ": " }, StringSplitOptions.None);

                selectedData[3] = $"Idő: {TimeField.Text}";
                ItemListBox.Items[selectedIndex] = string.Join(", ", selectedData);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string updatedTitle = TitleField.Text;
            string updatedCategory = CategoryField.Text;
            DateTime updatedDate = DatePicker.SelectedDate ?? DateTime.Now;
            string updatedTime = TimeField.Text;

            ItemListBox.Items[ItemListBox.SelectedIndex] = $"Cím: {updatedTitle}, Kategória: {updatedCategory}, Dátum: {updatedDate.ToString("yyyy-MM-dd")}, Idő: {updatedTime}";

        }

    }
}
