<?php

include('db.php');
session_start();
$user_check=$_SESSION['username'];
$ses_sql=mysqli_query($db,"SELECT username,ID FROM users WHERE username='$user_check'");
$row=mysqli_fetch_array($ses_sql,MYSQLI_ASSOC);
$loggedin_session=$row['username'];
$loggedin_id=$row['ID'];
if(!isset($loggedin_session) || $loggedin_session==NULL) {
header("Location: login.php");
}

?>