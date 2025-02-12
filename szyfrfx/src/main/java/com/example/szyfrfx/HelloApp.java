package com.example.szyfrfx;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.*;
import java.io.*;
import java.nio.file.*;

public class HelloApp extends Application {

    private TextArea poleTekstoweWejsciowe;
    private TextArea poleTekstoweWynikowe;
    private TextField poleKlucz;

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage glownaScena) {

        poleTekstoweWejsciowe = new TextArea();
        poleTekstoweWynikowe = new TextArea();
        poleKlucz = new TextField();
        Button przyciskZaszyfruj = new Button("Zaszyfruj");
        Button przyciskZapisz = new Button("Zapisz");
        Button przyciskOtworz = new Button("Otwórz");
        Button przyciskOdszyfruj = new Button("Odszyfruj");

        HBox boxKlucz = new HBox(10, new Label("Klucz: "), poleKlucz);
        VBox układ = new VBox(10, poleTekstoweWejsciowe, boxKlucz, przyciskZaszyfruj, przyciskZapisz, przyciskOtworz, przyciskOdszyfruj, poleTekstoweWynikowe);
        przyciskZaszyfruj.setOnAction(e -> szyfruj());
        przyciskZapisz.setOnAction(e -> zapisz());
        przyciskOtworz.setOnAction(e -> otworz());
        przyciskOdszyfruj.setOnAction(e -> deszyfruj());
        glownaScena.setTitle("Szyfrowanie i odszyfrowanie");
        glownaScena.setScene(new Scene(układ, 400, 500));
        glownaScena.show();
    }

    private void szyfruj() {
        try {
            int klucz = Integer.parseInt(poleKlucz.getText());
            String tekstWejsciowy = poleTekstoweWejsciowe.getText();
            String zaszyfrowanyTekst = szyfrCezara(tekstWejsciowy, klucz);
            poleTekstoweWynikowe.setText(zaszyfrowanyTekst);
        } catch (NumberFormatException e) {
            pokazAlert("Błąd", "Klucz musi być liczbą całkowitą");
        }
    }

    private void deszyfruj() {
        try {
            int klucz = Integer.parseInt(poleKlucz.getText());
            String tekstWejsciowy = poleTekstoweWejsciowe.getText();
            String odszyfrowanyTekst = szyfrCezara(tekstWejsciowy, -klucz);
            poleTekstoweWynikowe.setText(odszyfrowanyTekst);
        } catch (NumberFormatException e) {
            pokazAlert("Błąd", "Klucz musi być liczbą całkowitą");
        }
    }

    private void zapisz() {
        FileChooser wybieraczPlikow = new FileChooser();
        wybieraczPlikow.getExtensionFilters().add(new FileChooser.ExtensionFilter("Pliki tekstowe", "*.txt"));
        File plik = wybieraczPlikow.showSaveDialog(null);

        if (plik != null) {
            try {
                Files.write(plik.toPath(), poleTekstoweWynikowe.getText().getBytes());
            } catch (IOException e) {
                pokazAlert("Błąd", "Nie udało się zapisać pliku");
            }
        }
    }

    private void otworz() {
        FileChooser wybieraczPlikow = new FileChooser();
        wybieraczPlikow.getExtensionFilters().add(new FileChooser.ExtensionFilter("Pliki tekstowe", "*.txt"));
        File plik = wybieraczPlikow.showOpenDialog(null);

        if (plik != null) {
            try {
                String zawartosc = new String(Files.readAllBytes(plik.toPath()));
                poleTekstoweWejsciowe.setText(zawartosc);
            } catch (IOException e) {
                pokazAlert("Błąd", "Nie udało się otworzyć pliku");
            }
        }
    }

    private String szyfrCezara(String tekst, int klucz) {
        StringBuilder wynik = new StringBuilder();
        for (char c : tekst.toCharArray()) {
            if (Character.isLetter(c)) {
                char baza = Character.isLowerCase(c) ? 'a' : 'A';
                wynik.append((char) ((c - baza + klucz) % 26 + baza));
            } else {
                wynik.append(c);
            }
        }
        return wynik.toString();
    }

    private void pokazAlert(String tytul, String komunikat) {
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle(tytul);
        alert.setHeaderText(null);
        alert.setContentText(komunikat);
        alert.showAndWait();
    }
}
