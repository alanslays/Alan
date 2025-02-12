module com.example.zipfx {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.zipfx to javafx.fxml;
    exports com.example.zipfx;
}