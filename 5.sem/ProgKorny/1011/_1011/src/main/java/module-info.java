module com.example._1011 {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example._1011 to javafx.fxml;
    exports com.example._1011;
}