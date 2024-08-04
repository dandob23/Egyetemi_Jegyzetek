module com.multiwindow.progkornyjavafxmultiplewindowexample {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.multiwindow.main to javafx.fxml;
    exports com.multiwindow.main;
}