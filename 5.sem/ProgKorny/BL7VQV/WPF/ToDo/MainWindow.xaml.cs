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
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> toDoItems = new ObservableCollection<string>();
        private ToDoController toDoController;
        public MainWindow()
        {
            InitializeComponent();
            toDoController = new ToDoController();
            toDoController.SetMainWindow(this);

            addButton.Click += (sender, e) => toDoController.AddItem();
            editButton.Click += (sender, e) => toDoController.EditItem();
            //deleteButton.Click += (sender, e) => toDoController.DeleteItem();


            var addItemDialog = new AddItemDialog();
            addItemDialog.Initialize(toDoController);
            toDoController.ShowAllToDoItems(toDoItems);
        }

        internal void AddItemToList(string newItem)
        {
            if (listBox != null)
            {
                listBox.Items.Add(newItem);                
            }
        }

        internal void ShowAllToDoItems(ObservableCollection<string> toDoItems)
        {
            if (listBox != null)
            {
                listBox.Items.Clear();
                foreach (var item in toDoItems)
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            toDoController.AddItem();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selected = listBox.SelectedItem.ToString();

                int selectedIndex = listBox.SelectedIndex;
                listBox.Items[selectedIndex] = "Módosított elem";

                toDoController.ShowAllToDoItems(toDoItems);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);

                toDoController.ShowAllToDoItems(toDoItems);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                var selectedValue = listBox.SelectedItem.ToString();
                Console.WriteLine(selectedValue);
            }
        }
    }
}
