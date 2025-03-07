<?php
session_start();

$host = 'localhost';
$dbname = 'game';
$user = 'root'; 
$pass = ''; 

$conn = new mysqli($host, $user, $pass, $dbname);

if ($conn->connect_error) {
    die("Błąd połączenia z bazą danych: " . $conn->connect_error);
}

if ($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['register'])) {
    $username = trim($_POST['username']);
    $password = password_hash(trim($_POST['password']), PASSWORD_DEFAULT);
    
    $sql = "INSERT INTO users (username, password) VALUES (?, ?)";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("ss", $username, $password);
    
    if ($stmt->execute()) {
        echo "Rejestracja zakończona sukcesem! Możesz się teraz zalogować.";
    } else {
        echo "Błąd rejestracji: " . $stmt->error;
    }
    
    $stmt->close();
}

if ($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['login'])) {
    $username = trim($_POST['username']);
    $password = trim($_POST['password']);
    
    $sql = "SELECT id, username, password FROM users WHERE username = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("s", $username);
    $stmt->execute();
    $stmt->store_result();
    
    if ($stmt->num_rows > 0) {
        $stmt->bind_result($id, $user, $hashed_password);
        $stmt->fetch();
        
        if (password_verify($password, $hashed_password)) {
            $_SESSION['user_id'] = $id;
            $_SESSION['username'] = $user;
            echo "Zalogowano pomyślnie!";
        } else {
            echo "Błędne hasło.";
        }
    } else {
        echo "Nie znaleziono użytkownika.";
    }
    
    $stmt->close();
}
$conn->close();
?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Logowanie i Rejestracja</title>
</head>
<body>
    <h2>Logowanie</h2>
    <form method="POST" action="">
        <label for="username">Nazwa użytkownika:</label>
        <input type="text" id="username" name="username" required>
        <br>
        <label for="password">Hasło:</label>
        <input type="password" id="password" name="password" required>
        <br>
        <button type="submit" name="login">Zaloguj się</button>
    </form>
    
    <h2>Rejestracja</h2>
    <form method="POST" action="">
        <label for="reg_username">Nazwa użytkownika:</label>
        <input type="text" id="reg_username" name="username" required>
        <br>
        <label for="reg_password">Hasło:</label>
        <input type="password" id="reg_password" name="password" required>
        <br>
        <button type="submit" name="register">Zarejestruj się</button>
    </form>
    <footer>
        <p>Made by: Maciej Fleischer, Alan Nowicki. 2025</p>
    </footer>
</body>
</html>
