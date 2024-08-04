using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDo
{
    internal class ToDoController
    {
        private MainWindow mainWindow;
        private ObservableCollection<string> toDoItems = new ObservableCollection<string>();
    
        public void SetMainWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        
        public void ShowAllToDoItems(ObservableCollection<string> toDoItems)
        {
            this.toDoItems = toDoItems;
            mainWindow.ShowAllToDoItems(toDoItems);
        }
        public void ShowAddItemDialog()
        {
            var addItemDialog = new AddItemDialog();
            addItemDialog.Initialize(this);
            addItemDialog.ShowDialog();
        }

        public void ShowEditDialog(ObservableCollection<string> items)
        {
            var editItemDialog = new EditItemDialog();
            editItemDialog.Initialize(this);
            editItemDialog.LoadItemsToListBox(items);
            editItemDialog.ShowDialog();
        }

        /*public void ShowDeleteDialog()
        {
            var deleteItemDialog = new DeleteItemDialog();
            deleteItemDialog.Initialize(this);
            deleteItemDialog.ShowDialog();
        }*/


        public void AddItemToList(string newItem)
        {
            if(mainWindow != null)
            {
                mainWindow.AddItemToList(newItem);
            }
        }

        public void CloseAddItemDialog()
        {
            if(Application.Current.MainWindow is Window window)
            {
                window.Close();        
            }
        }

        public void AddItem()
        {
            ShowAddItemDialog();
        }

        public void EditItem()
        {
            ShowEditDialog(toDoItems);
        }

        /*public void DeleteItem()
        {
            ShowDeleteDialog();
        }*/
    
    }
}
