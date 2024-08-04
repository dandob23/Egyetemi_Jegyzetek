<?php 
session_start();
if(!empty($_SESSION['username'])) {
    header('location: main.php');
}
else{
    session_destroy();
}

$db = new mysqli("localhost","root","","users");
if (isset($_POST["send"])) {
    $errors = array();
    $true=true;
if (empty($_POST['username']))  {
    $true=false;
    array_push($errors, "A felhasználónév üres!");
}
if (empty($_POST['password']))  {
    $true=false;
    array_push($errors, "A jelszó üres!");
}
if ($true) {
    $username = mysqli_real_escape_string($db, $_POST['username']);
    $password = mysqli_real_escape_string($db, $_POST['password']);
    $password = md5($password);
    $sql = "SELECT * FROM users WHERE username = '$username' AND password ='$password'";
    $query =$db->query($sql);
    if (mysqli_num_rows($query)==1) {
        session_start();
        $_SESSION['username'] = $username;
        header('location: main.php');
        }
        else {
            array_push($errors, "A felhasználónév, vagy a jelszó helytelen!");
        }
}

}

$db->close();

?>
<!DOCTYPE html>
<html>
<head>
	<title>PlanTutorial</title>
	<meta charset="UTF-8">
	<meta http-equiv="content-style-type" content="text/css">
	<link rel="stylesheet" type="text/css" href="style/logstyle.css">
    <style>     
        body {
            animation: fadeInAnimation ease 2s;
            animation-iteration-count: 1;
            animation-fill-mode: forwards;
        }
        @keyframes fadeInAnimation {
            0% {opacity: 20%;}
            100% {
                opacity: 1;
            }
        }
        
    </style>
</head>
<body style="background-color: rgb(160, 189, 122)">
    <div class="header" style="width:100%"><header>
    <div     style="width:100%; margin:auto;">
	        <h1 style="padding-right:10px;">PlanTutorial </h1>
            <h2 style="padding-right:10px;">by Dobozy Dániel (BL7VQV) </h2>
    </div></div></header>

    
<div style="margin-left: 240px;font-size: 20px; width: 100%; position: relative; top: 0px; -webkit-text-stroke-width: 0.5px;
    -webkit-text-stroke-color: black">
	<form action="login.php" method="POST">
        <table>
            <tr><td  style="font-size: 30px; padding-bottom:10px"><b>Bejelentkezés</b> </td><td><td></td>
		<tr><td>Felhasználónév: </td><td><input type="text" name="username" ></td></tr>
		<tr><td>Jelszó: </td><td><input type="password" name="password"></td></tr></tr>
		<tr><td><input value="Bejelentkezés" type="submit" name="send"></td>
        <tr><td></td></tr>
        <tr><td style="padding-top 20px">Még nincs fiókod? <a href='register.php'><input type='button' value='Regisztráció' name='reg'></a></td></tr>
        <tr><td></td></tr>
        <tr><td></td></tr>
	   </table></form></div>
<?php 
if(!empty($errors)){
    foreach($errors as $key){
        echo $key."<br/>";
    }
}
?>

</body>
</html>