<?php 
$dbu = new mysqli('localhost','root','','users');

if ($dbu->connect_error) {
    die("Csatlakozás sikertelen: " . $dbu->connect_error);
}

$dbp = new mysqli('localhost','root','','plantutorial');

if ($dbp->connect_error) {
    die("Csatlakozás sikertelen: " . $dbp->connect_error);
}

?>