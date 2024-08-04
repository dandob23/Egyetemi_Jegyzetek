package com.example.todo;

import com.example.Controller.AddItemDialogController;
import com.example.Controller.DeleteItemDialogController;
import com.example.Controller.EditItemDialogController;
import com.example.Controller.ToDoController;
import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

import java.io.IOException;
import java.time.LocalDateTime;
import java.util.Optional;

public class ToDo extends Application {
    private static  ToDo instance;
    private ToDoController controller;
    private ObservableList<String> toDoItems = FXCollections.observableArrayList();

    public ToDo(){
        instance = this;
    }

    public static ToDo getInstance(){
        return instance;
    }

    @Override
    public void start(Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(ToDo.class.getResource("ToDo.fxml"));
        Parent root = fxmlLoader.load();
        Scene scene = new Scene(root);
        stage.setTitle("To-Do lista!");
        stage.setScene(scene);
        stage.show();

        controller = fxmlLoader.getController();
        controller.setToDoApp(this);

        VBox vBox = (VBox) root;

        Button addButton = (Button) vBox.lookup("#addButton");
        addButton.setOnAction(event->showAddDialog());

        Button editButton = (Button) vBox.lookup("#editButton");
        editButton.setOnAction(event->showEditDialog());

        Button deleteButton = (Button) vBox.lookup("#deleteButton");
        deleteButton.setOnAction(event->showDeleteDialog());
    }

    public void showAllToDoItems(ObservableList<String> toDoItems){
        this.toDoItems = toDoItems;
        controller.showAllToDoItems(this.toDoItems);
    }

    public void showAddDialog(){
        Dialog<String[]> dialog = new Dialog<>();
        dialog.setTitle("Elem hozzáadása");
        dialog.setHeaderText("Kérem adja meg az elem adatait: ");

        FXMLLoader dialogLoader = new FXMLLoader(ToDo.class.getResource("AddItemDialog.fxml"));
        try {
            dialog.getDialogPane().setContent(dialogLoader.load());
        }catch (IOException e){
            e.printStackTrace();
        }

        AddItemDialogController dialogController = dialogLoader.getController();
        dialogController.initData(controller);

        dialog.getDialogPane().getButtonTypes().addAll(ButtonType.OK, ButtonType.CANCEL);
        dialog.setResultConverter(button -> {
            if (button == ButtonType.OK){
                return dialogController.processResult();
            }
            return null;
        });

        Optional<String[]> result = dialog.showAndWait();
        result.ifPresent(data -> {
            LocalDateTime now = LocalDateTime.now();
            LocalDateTime specifiedDateTime = LocalDateTime.parse(data[2] + "T" + data[3] + ":00");
            if (now.equals(specifiedDateTime)){
                Alert alert = new Alert(Alert.AlertType.INFORMATION);
                alert.setTitle("Értesítés");
                alert.setHeaderText("Időpont egyezés!");
                alert.setContentText("Cím: " + data[0] + "\nKategória: " + data[1] + "\nDátum: " + data[2] + "\nIdő: " + data[3]);
                alert.show();
            }
        });
    }

    public void showEditDialog(){
        try {
            FXMLLoader fxmlLoader = new FXMLLoader(ToDo.class.getResource("EditItemDialog.fxml"));
            VBox editDialog = fxmlLoader.load();
            EditItemDialogController editDialogController = fxmlLoader.getController();
            editDialogController.setToDoItems(toDoItems);

            Scene scene = new Scene(editDialog);
            Stage stage = new Stage();
            stage.setScene(scene);
            stage.setTitle("Elem szerkesztése");
            stage.show();
        } catch (IOException e){
            e.printStackTrace();
        }
    }

    public void showDeleteDialog(){
        Dialog<Void> dialog = new Dialog<>();
        dialog.setTitle("Elem törlése");
        dialog.setHeaderText("Válassza ki az elemet a törléshez: ");

        FXMLLoader dialogLoader = new FXMLLoader(ToDo.class.getResource("DeleteItemDialog.fxml"));
        try{
            dialog.getDialogPane().setContent(dialogLoader.load());
        }catch (IOException e)
        {
            e.printStackTrace();
        }

        DeleteItemDialogController dialogController = dialogLoader.getController();
        dialogController.setToDoItems(toDoItems);

        dialog.getDialogPane().getButtonTypes().addAll(ButtonType.CANCEL);
        dialog.showAndWait();
    }

    public static void main(String[] args) {
        launch();
    }
}