package com.example.javafxjdbc;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

import java.sql.*;

public class HelloApplication extends Application {

    private static final String DB_URL = "jdbc:mysql://localhost:3306/school";
    private static final String USER = "root";
    private static final String PASS = "";

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        Button createTableButton = new Button("Create Table");
        Button dropTableButton = new Button("Drop Table");
        Button updateTableButton = new Button("Update Table");
        Button insertIntoButton = new Button("Insert Data");

        createTableButton.setOnAction(e -> createTable());
        dropTableButton.setOnAction(e -> dropTable());
        updateTableButton.setOnAction(e -> updateTable());
        insertIntoButton.setOnAction(e -> insertInto());

        VBox vbox = new VBox(10, createTableButton, dropTableButton, updateTableButton, insertIntoButton);
        Scene scene = new Scene(vbox, 300, 200);
        primaryStage.setScene(scene);
        primaryStage.setTitle("Database App");
        primaryStage.show();
    }

    private void createTable() {
        String sql = "CREATE TABLE IF NOT EXISTS students (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), grade INT, age INT)";
        executeStatement(sql, "Table created successfully");
    }

    private void dropTable() {
        String sql = "DROP TABLE IF EXISTS students";
        executeStatement(sql, "Table dropped successfully");
    }

    private void updateTable() {
        Stage updateTableStage = new Stage();
        TextField columnNameField = new TextField();
        TextField newValueField = new TextField();
        TextField idField = new TextField();
        Button updateButton = new Button("Update Table");

        updateButton.setOnAction(e -> {
            try {
                int id = Integer.parseInt(idField.getText());
                updateTableInDatabase(columnNameField.getText(), newValueField.getText(), id);
                updateTableStage.close();
            } catch (NumberFormatException ex) {
                System.err.println("Invalid ID format");
            }
        });

        VBox vbox = new VBox(10, new Label("Column Name:"), columnNameField,
                new Label("New Value:"), newValueField,
                new Label("ID:"), idField, updateButton);
        updateTableStage.setScene(new Scene(vbox, 300, 250));
        updateTableStage.show();
    }

    private void updateTableInDatabase(String columnName, String newValue, int id) {
        String sql = "UPDATE students SET " + columnName + " = ? WHERE id = ?";
        try (Connection conn = DriverManager.getConnection(DB_URL, USER, PASS);
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, newValue);
            pstmt.setInt(2, id);
            pstmt.executeUpdate();
            System.out.println("Table updated successfully");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void insertInto() {
        Stage insertIntoStage = new Stage();
        TextField nameField = new TextField();
        TextField gradeField = new TextField();
        TextField ageField = new TextField();
        Button insertButton = new Button("Insert Data");

        insertButton.setOnAction(e -> {
            try {
                int grade = Integer.parseInt(gradeField.getText());
                int age = Integer.parseInt(ageField.getText());
                insertIntoDatabase(nameField.getText(), grade, age);
                insertIntoStage.close();
            } catch (NumberFormatException ex) {
                System.err.println("Invalid number format");
            }
        });

        VBox vbox = new VBox(10, new Label("Name:"), nameField,
                new Label("Grade:"), gradeField,
                new Label("Age:"), ageField, insertButton);
        insertIntoStage.setScene(new Scene(vbox, 300, 250));
        insertIntoStage.show();
    }

    private void insertIntoDatabase(String name, int grade, int age) {
        String sql = "INSERT INTO students (name, grade, age) VALUES (?, ?, ?)";
        try (Connection conn = DriverManager.getConnection(DB_URL, USER, PASS);
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, name);
            pstmt.setInt(2, grade);
            pstmt.setInt(3, age);
            pstmt.executeUpdate();
            System.out.println("Data inserted successfully");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void executeStatement(String sql, String successMessage) {
        try (Connection conn = DriverManager.getConnection(DB_URL, USER, PASS);
             Statement stmt = conn.createStatement()) {
            stmt.executeUpdate(sql);
            System.out.println(successMessage);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
