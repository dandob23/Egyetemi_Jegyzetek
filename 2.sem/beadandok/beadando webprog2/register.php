<?php 

    $db = new mysqli ('localhost','root', '','users');

    if(isset($_POST['submit']))
    {
        $errors = array();
        $true = true;
        
        if(empty($_POST['username']))
        {
            $true = false;
            array_push($errors, "A felhasználónév üres!");
        }

        if(empty($_POST['email']))
        {
            $true = false;
            array_push($errors, "Az email üres!");
        }

        if(empty($_POST['vezeteknev']))
        {
            $true = false;
            array_push($errors, "A vezetéknév üres!");
        }

        if(empty($_POST['keresztnev']))
        {
            $true = false;
            array_push($errors, "A keresztnév üres!");
        }

        if(empty($_POST['password']))
        {
            $true = false;
            array_push($errors, "A jelszó üres!");
        }

        if(empty($_POST['password_2']))
        {
            $true = false;
            array_push($errors, "A jelszó megerősítése helytelen!");
        }

        if(!($_POST['password']==$_POST['password_2'])){
            $true=false;
            array_push($errors, "A jelszavak nem egyenlőek!");
        }

        if(empty($_POST['agree']))
        {
            $true = false;
            array_push($errors, "A feltételek hozzájárulása nélkül nem lehet regisztrálni! ");
        }

        if ($true){
            $username = mysqli_real_escape_string($db, $_POST ['username']);
            $email = mysqli_real_escape_string($db, $_POST ['email']);
            $vezeteknev = mysqli_real_escape_string($db, $_POST ['vezeteknev']);
            $keresztnev = mysqli_real_escape_string($db, $_POST ['keresztnev']);
            $password = mysqli_real_escape_string($db, $_POST ['password']);
            $password = md5($password);

            $sql ="INSERT INTO users (username,email,vezeteknev,keresztnev, password, date) values ('$username','$email','$vezeteknev','$keresztnev','$password',NOW())";
            $db->query ($sql);

            session_start();
            header('location: login.php');
            array_push($username == "username");
            array_push($password == "password");           
            
        }
        
        
    }
  
    $db->close();


    ?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style/regstyle.css">
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
    <title>Regisztráció</title>
    </head>
<body>
<h1>Regisztrálás</h1>
<h2>
<form action="register.php" method="POST">
        <div>Felhasználónév: <input type="text" name="username"/></div>
        <div>Email: <input type="text" name="email"/></div>
        <div>Vezetéknév: <input type="text" name="vezeteknev"/></div>
        <div>Keresztnév: <input type="text" name="keresztnev"/></div>
        <div>Jelszó: <input type="password" name="password"/></div>
        <div>Jelszó újra: <input type="password" name="password_2"/></div>
        <div><label for="agree"><input type="checkbox" name="agree" id="agree" value="yes"/> Hozzájárulok, az
        <a href='felt.html' title="Feltételek">itt </a>lévő összes feltételhez! 
        </label>
        <input value="Regisztráció!" type="submit" name="submit"/></div>
        <footer>Tag vagy már? <a href="login.php">Bejelentkezés</a></footer>
    </form></h2>
    
    <h4><form action="uploadprofpic.php" style ="margin-left:15%" method="post" enctype="multipart/form-data">
    Válassz ki képet a feltöltéshez:
    <input type="file" name="file">
    <input type="submit" name="submit" value="Upload"></form></h4>
    

    <?php 
        if(!empty($errors)){
            foreach ($errors as $key) {
                echo $key."<br/>";
            }
        }

    ?>
</body>
</html>
