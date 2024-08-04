package com.multiwindow.main;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class FirstWidowApp extends Application {
    Stage stage;
    @Override
    public void start(Stage stage) throws IOException {
        this.stage = stage;
        FXMLLoader fxmlLoader = new FXMLLoader(FirstWidowApp.class.getResource("first-window.fxml"));
        Scene scene = new Scene(fxmlLoader.load());
        FirstWindowController controller = fxmlLoader.getController();
        controller.application = this;

        stage.setTitle("First window");
        stage.setScene(scene);
        stage.show();
        stage.setMinWidth(stage.getWidth());
        stage.setMinHeight(stage.getHeight());
    }
    public void Show() {
        stage.show();
    }
    public void Hide() {
        stage.hide();
    }
    public static void main(String[] args) {
        launch();
    }
}