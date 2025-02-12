package com.example.zipfx;

import javafx.application.Application;
import javafx.stage.*;
import javafx.scene.*;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.FileChooser;
import java.io.*;
import java.util.List;
import java.util.zip.*;

public class Main extends Application {

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {

        Button compressButton = new Button("Kompresuj pliki");
        Button decompressButton = new Button("Dekompresuj plik");


        Label label = new Label("Wybierz operację:");

        // Layout
        VBox layout = new VBox(10, label, compressButton, decompressButton);
        layout.setPadding(new javafx.geometry.Insets(20));
        Scene scene = new Scene(layout, 400, 200);


        compressButton.setOnAction(e -> {
            try {
                compressFiles(primaryStage);
            } catch (IOException ex) {
                showError("Błąd kompresji", ex.getMessage());
            }
        });


        decompressButton.setOnAction(e -> {
            try {
                decompressFile(primaryStage);
            } catch (IOException ex) {
                showError("Błąd dekompresji", ex.getMessage());
            }
        });

        primaryStage.setTitle("Archiwum ZIP");
        primaryStage.setScene(scene);
        primaryStage.show();
    }


    private void compressFiles(Stage stage) throws IOException {
        FileChooser fileChooser = new FileChooser();
        fileChooser.getExtensionFilters().add(new FileChooser.ExtensionFilter("Wszystkie pliki", "*.*"));
        fileChooser.getExtensionFilters().add(new FileChooser.ExtensionFilter("Tekstowe pliki", "*.txt"));
        List<File> filesToZip = fileChooser.showOpenMultipleDialog(stage);

        if (filesToZip != null && !filesToZip.isEmpty()) {
            FileChooser saveChooser = new FileChooser();
            saveChooser.getExtensionFilters().add(new FileChooser.ExtensionFilter("ZIP Archives", "*.zip"));
            File zipFile = saveChooser.showSaveDialog(stage);

            if (zipFile != null) {
                try (FileOutputStream fos = new FileOutputStream(zipFile);
                     ZipOutputStream zipOut = new ZipOutputStream(fos)) {
                    for (File file : filesToZip) {
                        try (FileInputStream fis = new FileInputStream(file)) {
                            ZipEntry zipEntry = new ZipEntry(file.getName());
                            zipOut.putNextEntry(zipEntry);
                            byte[] bytes = new byte[1024];
                            int length;
                            while ((length = fis.read(bytes)) >= 0) {
                                zipOut.write(bytes, 0, length);
                            }
                            zipOut.closeEntry();
                        }
                    }
                }
                showInfo("Sukces", "Pliki zostały skompresowane do " + zipFile.getAbsolutePath());
            }
        }
    }


    private void decompressFile(Stage stage) throws IOException {
        FileChooser fileChooser = new FileChooser();
        fileChooser.getExtensionFilters().add(new FileChooser.ExtensionFilter("ZIP Archives", "*.zip"));
        File zipFile = fileChooser.showOpenDialog(stage);

        if (zipFile != null) {
            DirectoryChooser directoryChooser = new DirectoryChooser();
            File destinationDir = directoryChooser.showDialog(stage);

            if (destinationDir != null) {
                try (ZipInputStream zis = new ZipInputStream(new FileInputStream(zipFile))) {
                    ZipEntry zipEntry = zis.getNextEntry();
                    byte[] buffer = new byte[1024];

                    while (zipEntry != null) {
                        File newFile = new File(destinationDir, zipEntry.getName());
                        new File(newFile.getParent()).mkdirs();

                        try (FileOutputStream fos = new FileOutputStream(newFile)) {
                            int len;
                            while ((len = zis.read(buffer)) > 0) {
                                fos.write(buffer, 0, len);
                            }
                        }

                        zipEntry = zis.getNextEntry();
                    }
                    showInfo("Sukces", "Plik został zdekompresowany do " + destinationDir.getAbsolutePath());
                }
            }
        }
    }


    private void showInfo(String title, String message) {
        Alert alert = new Alert(Alert.AlertType.INFORMATION);
        alert.setTitle(title);
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.showAndWait();
    }

    // Funkcja do wyświetlania komunikatu o błędzie
    private void showError(String title, String message) {
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle(title);
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.showAndWait();
    }
}
