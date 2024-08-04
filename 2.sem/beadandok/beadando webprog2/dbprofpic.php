<?php
$dbHost     = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName     = "users";

$dbp = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);
$allowTypes = array('jpg','jpeg');

if ($dbp->connect_error) {
    die("Csatlakozás sikertelen: " . $dbp->connect_error);
}
?>