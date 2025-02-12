module com.example.szyfrfx {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.szyfrfx to javafx.fxml;
    exports com.example.szyfrfx;
}