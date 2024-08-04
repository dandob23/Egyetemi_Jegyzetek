package com.example._1011;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.input.KeyEvent;

public class HelloController
{
    @FXML
    public void initialize(){
        HelloBTN.setOnAction(e -> {
            System.out.println("Actioooon");
        });
        HelloBTN.setOnKeyPressed(this::OnKeyPressed);
    }

    private void OnKeyPressed(KeyEvent event){
        System.out.println(event.getText());
    }
    @FXML
    public Button HelloBTN;

    @FXML
    private Label welcomeText;

    @FXML
    protected void onHelloButtonClick()
    {
        welcomeText.setText("Welcome to JavaFX Application!");
    }
}