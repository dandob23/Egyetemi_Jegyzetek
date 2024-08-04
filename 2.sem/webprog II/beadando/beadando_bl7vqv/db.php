<?php 
$dbHost     = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName     = "users";

$db = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);

if ($db->connect_error) {
    die("Csatlakozás sikertelen: " . $db->connect_error);
}
?>