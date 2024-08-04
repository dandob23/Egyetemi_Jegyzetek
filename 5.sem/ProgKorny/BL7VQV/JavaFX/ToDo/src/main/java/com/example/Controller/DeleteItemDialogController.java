package com.example.Controller;

import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.ListView;

import java.nio.channels.spi.AbstractSelectionKey;
import java.util.Optional;

public class DeleteItemDialogController {

    @FXML
    private ListView<String> itemListView;

    public void setToDoItems(ObservableList<String> toDoItems){
        itemListView.setItems(toDoItems);
    }

    @FXML
    private void deleteItem(){
        String selectedItem = itemListView.getSelectionModel().getSelectedItem();
        if(selectedItem != null) {
            Alert alert = new Alert(Alert.AlertType.CONFIRMATION);
            alert.setTitle("Törlés megerősítése");
            alert.setHeaderText("Biztosan törölni szeretné a kijelölt elemet?");
            alert.setContentText(selectedItem);

            Optional<ButtonType> result = alert.showAndWait();
            if (result.isPresent() && result.get() == ButtonType.OK) {
                itemListView.getItems().remove(selectedItem);
            }
        } else {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.setTitle("Nincs kijelölt elem");
            alert.setHeaderText("Kérjük válasszon ki egy elemet a törléshez!");
            alert.show();
            }
        }
    }
