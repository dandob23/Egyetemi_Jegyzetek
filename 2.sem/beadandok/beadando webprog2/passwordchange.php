<!DOCTYPE html>
<html lang="hu">
<head>
<title>PassChange</title>
<meta charset="UTF-8">
<meta http-equiv="content-style-type" content="text/css">
</head>
<body>
<h3 align="center">JELSZÓ VÁLTOZTATÁS</h3>


   <form method="POST" action="password_change.php">
    <table>
    <tr>
   <td>Felhasználónév</td>
    <td><input type="username" size="10" name="username"></td>
    </tr>
    <tr>
    <td>Jelenlegi jelszó</td>
    <td><input type="password" size="10" name="password"></td>
    </tr>
  <tr>
    <td>Új jelszó:</td>
    <td><input type="password" size="10" name="newpassword"></td>
    </tr>
    <tr>
   <td>Új jelszó újra:</td>
   <td><input type="password" size="10" name="confirmnewpassword"></td>
    </tr>
    </table>
    <p><input type="submit" value="Update Password">
    </form>
   <p><a href="main.php">Home</a>
   <p><a href="logout.php">Kijelentkezés</a>
 
   <?php 

session_start();

include 'db.php';

$username = $_POST['username'];
$password = $_POST['password'];
$newpassword = $_POST['newpassword'];
$confirmnewpassword = $_POST['confirmnewpassword'];

$result = mysql_query("SELECT password FROM users WHERE user_id='$username'");
        if(!$result)
        {
        echo "Ez a felhasználónév nem létezik";
        }
        else if($password!= mysql_result($result, 0))
        {
        echo "Helytelen jelszó";
        }
        if($newpassword=$confirmnewpassword)

        $sql=mysql_query("UPDATE users SET password='$newpassword' where  user_id='$username'");

        if($sql)
        {
        echo "Jelszó átírva";
        }
       else
        {
       echo "A jelszók különböznek";
       }

      ?>

</body>
</html>