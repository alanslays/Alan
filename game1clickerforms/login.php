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

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
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
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Logowanie</title>
</head>
<body>
    <h2>Log in</h2>
    <form method="POST" action="">
        <label for="username">Username: </label>
        <input type="text" id="username" name="username" required>
        <br>
        <label for="password">Password: </label>
        <input type="password" id="password" name="password" required>
        <br>
        <button type="submit">Log in</button>
    </form>

    <div class="register">
        Don't have an account yet? <a href="register.php">Register now!</a>
    </div>
    <footer>
        <p>Made by: Maciej Fleischer, Alan Nowicki. 2025</p>
    </footer>
</body>
</html>
