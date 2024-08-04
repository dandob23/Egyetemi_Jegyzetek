<?php
$dbHost     = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName     = "plantutorial";

$dbp = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);

if ($dbp->connect_error) {
    die("Csatlakozás sikertelen: " . $dbp->connect_error);
}
?>