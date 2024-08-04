<?php
$dbHost     = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName     = "plantutorial";

$dbpr = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);
$allowTypes = array('jpg','jpeg');

if ($dbpr->connect_error) {
    die("Csatlakozás sikertelen: " . $dbpr->connect_error);
}
?>