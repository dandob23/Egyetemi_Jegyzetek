package com.example.Controller;

import com.example.todo.ToDo;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.ListView;
import javafx.stage.Stage;

public class ToDoController {

    private ToDo toDoApp;
    public void setToDoApp(ToDo toDo){
        this.toDoApp = toDo;
    }

    @FXML
    private ListView<String> toDoListView;

    @FXML
    private Button addButton;

    @FXML
    private Button editButton;

    @FXML
    private Button deleteButton;

    public void showAllToDoItems(ObservableList<String> toDoItems){
        toDoListView.setItems(toDoItems);
    }

    @FXML
    private void addItem(){
        toDoApp.showAddDialog();
    }

    @FXML
    private void editItem(){

    }

    @FXML
    private void deleteItem(){

    }
}
