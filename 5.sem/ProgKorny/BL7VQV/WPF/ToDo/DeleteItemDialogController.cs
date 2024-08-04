using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ToDo
{
    internal class DeleteItemDialogController
    {
        private ObservableCollection<string> toDoItems;
        private ListView itemListView;



        internal void SetToDoItems(ObservableCollection<string> toDoItems)
        {
            this.toDoItems = toDoItems;
            itemListView.ItemsSource = toDoItems;
        }

        internal void ShowDialog()
        {
            Window dialog = new Window
            {
                Title = "Elem törlése",
                Width = 400,
                Height = 300,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            itemListView = new ListView();
            itemListView.ItemsSource = toDoItems;

            Button deleteButton = new Button
            {
                Content = "Törlés",
                Width = 100,
                Height = 30,
                Margin = new Thickness(10),
                HorizontalAlignment = HorizontalAlignment.Center
            };

            deleteButton.Click += DeleteItem;

            StackPanel panel = new StackPanel();
            panel.Children.Add(itemListView);
            panel.Children.Add(deleteButton);

            dialog.Content = panel;
            dialog.ShowDialog();
        }

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            string selectedItem = itemListView.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Biztosan törölni szeretnéd?", "Elem törlése", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    toDoItems.Remove(selectedItem);
                    MessageBox.Show("Sikeres törlés!", "Elem törlése", MessageBoxButton.OK, MessageBoxImage.Information);

                    itemListView.ItemsSource = null;
                    itemListView.ItemsSource = toDoItems;
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva elem!", "Elem törlése", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
