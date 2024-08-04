module com.example.todo {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.todo to javafx.fxml;
    opens com.example.Controller;
    exports com.example.todo;
}