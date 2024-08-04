package com.multiwindow.main;

import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.RadioButton;
import javafx.stage.Stage;

public class SecondWindowApp extends Application {
    @Override
    public void start(Stage stage) throws Exception {
        FXMLLoader fxmlLoader = new FXMLLoader(SecondWindowApp.class.getResource("second-window.fxml"));
        Scene scene = new Scene(fxmlLoader.load());
        stage.setTitle("Second window");
        stage.setScene(scene);
        stage.setMinWidth(190);
        stage.setMinHeight(239);
        stage.setMaxWidth(190);
        stage.setMaxHeight(239);
        stage.showAndWait();

        setValues(fxmlLoader.getController());
    }

    private void setValues(SecondWindowController controller){
        checkBoxChecked = controller.checkbox.isSelected();
        choiceBoxSelected = (int) controller.choiceBox.getValue();
        comboBoxSelected = (String) controller.comboBox.getValue();
        radioButtonSelected = ((RadioButton)controller.myToggleGroup.getSelectedToggle()).getText();
        sliderValue = controller.slider.getValue();
    }
    public static ObservableList<Integer> CHOICE_BOX_LIST = FXCollections.observableArrayList(1,2,3,4,5,6,7,8,9);
    public static ObservableList<String> COMBO_BOX_LIST = FXCollections.observableArrayList("aaa", "bbb", "ccc", "ddd");

    public boolean checkBoxChecked;
    public int choiceBoxSelected;
    public String comboBoxSelected;
    public String radioButtonSelected;
    public double sliderValue;
}
