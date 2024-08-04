package com.example.Controller;

import com.example.todo.ToDo;
import javafx.beans.Observable;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.DatePicker;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.time.LocalDate;
import java.time.LocalDateTime;

public class AddItemDialogController {
    private ToDoController toDoApp;

    private ObservableList<String> toDoItems = FXCollections.observableArrayList();

    @FXML
    private TextField titleField;

    @FXML
    private TextField categoryField;

    @FXML
    private DatePicker datePicker;

    @FXML
    private TextField timeField;

    @FXML
    private Button saveButton;

    public void initData(ToDoController toDo){
        this.toDoApp = toDo;
    }

    public String[] processResult(){
        String[] data = new String[4];
        data[0] = titleField.getText();
        data[1] = categoryField.getText();
        data[2] = datePicker.getValue().toString();
        data[3] = timeField.getText();

        return data;
    }

    @FXML
    private void saveItem(){
        String title = titleField.getText();
        String category = categoryField.getText();
        String date = datePicker.getValue().toString();
        String time = timeField.getText();

        String newItem = "Cím: " + title + ", Kategória: " + category + ", Dátum: " + date + ", Idő: " + time;

        toDoItems.add(newItem);

        titleField.clear();
        categoryField.clear();
        datePicker.getEditor().clear();
        timeField.clear();

        ToDo.getInstance().showAllToDoItems(toDoItems);
    }
}
