<?php

$host = 'localhost';
$dbname = 'game';
$user = 'root'; 
$pass = ''; 

$conn = new mysqli($host, $user, $pass, $dbname);

if ($conn->connect_error) {
    die("Błąd połączenia z bazą danych: " . $conn->connect_error);
}

// Pobranie danych do leaderboarda
$leaderboardQuery = "SELECT username, score FROM users ORDER BY score DESC LIMIT 10";
$leaderboardResult = $conn->query($leaderboardQuery);

$conn->close();
?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Leaderboard</title>
</head>
<body>
    <h2>Leaderboard</h2>
    <table border="1">
        <tr>
            <th>Place</th>
            <th>User</th>
            <th>Points</th>
        </tr>
        <?php 
        if ($leaderboardResult->num_rows > 0) {
            $place = 1;
            while ($row = $leaderboardResult->fetch_assoc()) {
                echo "<tr><td>" . $place . "</td><td>" . htmlspecialchars($row['username']) . "</td><td>" . $row['score'] . "</td></tr>";
                $place++;
            }
        } else {
            echo "<tr><td colspan='3'>No Data</td></tr>";
        }
        ?>
    </table>
</body>
</html>
