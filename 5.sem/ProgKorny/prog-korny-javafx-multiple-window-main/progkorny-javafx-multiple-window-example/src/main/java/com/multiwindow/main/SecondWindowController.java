package com.multiwindow.main;

import javafx.fxml.FXML;
import javafx.scene.control.*;

public class SecondWindowController {
    @FXML
    public void initialize() {
        choiceBox.setItems(SecondWindowApp.CHOICE_BOX_LIST);
        choiceBox.setValue(SecondWindowApp.CHOICE_BOX_LIST.get(0));

        comboBox.setItems(SecondWindowApp.COMBO_BOX_LIST);
        comboBox.setValue(SecondWindowApp.COMBO_BOX_LIST.get(0));
    }

    public CheckBox checkbox;
    public ChoiceBox choiceBox;
    public ComboBox comboBox;
    public ToggleGroup myToggleGroup;
    public Slider slider;
}
