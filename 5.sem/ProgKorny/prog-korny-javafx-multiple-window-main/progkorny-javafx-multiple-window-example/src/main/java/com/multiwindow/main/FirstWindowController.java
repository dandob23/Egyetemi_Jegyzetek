package com.multiwindow.main;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.stage.Stage;

public class FirstWindowController {
    public FirstWidowApp application;
    public Label checkBoxCheckedLBL;
    public Label choiceBoxSelectedLBL;
    public Label comboBoxSelectedLBL;
    public Label radioButtonSelectedLBL;
    public Label sliderValueLBL;

    @FXML
    public void initialize() {
        showSecondWindowBTN.setOnAction(this::showSecondWindowBTNOnAction);
    }

    private void showSecondWindowBTNOnAction(ActionEvent event) {
        application.Hide();
        try {
            SecondWindowApp secondApp = new SecondWindowApp();
            secondApp.start(new Stage());
            checkBoxCheckedLBL.setText(secondApp.checkBoxChecked ? "Yes" : "No");
            choiceBoxSelectedLBL.setText(String.valueOf(secondApp.choiceBoxSelected));
            comboBoxSelectedLBL.setText(secondApp.comboBoxSelected);
            radioButtonSelectedLBL.setText(secondApp.radioButtonSelected);
            sliderValueLBL.setText(String.valueOf(secondApp.sliderValue));
        }
        catch (Exception ignored) {}
        application.Show();
    }

    public Button showSecondWindowBTN;
}