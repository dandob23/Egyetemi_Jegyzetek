package com.example.Controller;

import com.example.todo.ToDo;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.DatePicker;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;

import java.time.LocalDate;
import java.util.List;

public class EditItemDialogController {

    @FXML
    private ListView<String> itemListView;

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

    private ObservableList<String> toDoItems;

    public void setToDoItems(ObservableList<String> items) {
        this.toDoItems = items;
        itemListView.setItems(items);
        itemListView.getSelectionModel().selectedItemProperty().addListener((observable, oldValue, newValue) -> {
            if (newValue != null){
                String[] parts = newValue.split(", ");
                String title = parts[0].substring(5);
                String category = parts[1].substring(11);
                String date = parts[2].substring(7);
                String time = parts[3].substring(6);

                titleField.setText(title);
                categoryField.setText(category);
                datePicker.setValue(LocalDate.parse(date));
                timeField.setText(time);
            }
        });
    }

    @FXML
    private void saveItem() {
        String selectedItem = itemListView.getSelectionModel().getSelectedItem();
        int selectedIndex = itemListView.getSelectionModel().getSelectedIndex();

        if (selectedItem != null && selectedIndex >=0){
            String updatedItem =
                    "Cím: " + titleField.getText() +
                    ", Kategória: " + categoryField.getText() +
                    ", Dátum: " + datePicker.getValue().toString() +
                    ", Idő: " + timeField.getText();

            toDoItems.set(selectedIndex, updatedItem);
            ToDo.getInstance().showAllToDoItems(toDoItems);
        }
    }
}
