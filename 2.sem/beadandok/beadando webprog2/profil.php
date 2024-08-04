<?php 
include('session.php');
include('dbprofpic.php');
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style/profilstyle.css">
    <title>Profil</title>
</head>
<body>
<nav class="nav-sticky">
  <ul style="-webkit-text-stroke-width: 0.1px;
    -webkit-text-stroke-color: black;">
    <li><a href="adatok.php">Növények adatai</a></li>
    <li><a href="addplant.php">Új növény hozzáadása</a></li>
    <li><a href="main.php">Vissza a főoldalra</a></li>
    <li><a href="logout.php">Kijelentkezés</a></li>
  </ul>

<header>
  <h1>PlanTutorial</h1>
</header></br>


<h1 style="color:white; padding-left:10px">Saját profilom: </h2>

<?php 

$db = new mysqli("localhost","root","","users");

$sql="SELECT * FROM users WHERE ID=$loggedin_id";
$result=mysqli_query($db,$sql);

echo "<table border='1'>
<tr>
<th>Felhasználónév</th>
<th>Email</th>
<th>Vezetéknév</th>
<th>Keresztnév</th>
<th>Regisztrált</th>
</tr>";

while($row = mysqli_fetch_array($result))
{
echo "<tr>";
echo "<td>" . $row['username'] . "</td>";
echo "<td>" . $row['email'] . "</td>";
echo "<td>" . $row['vezeteknev'] . "</td>";
echo "<td>" . $row['keresztnev'] . "</td>";
echo "<td>" . $row['Date'] . "</td>";
echo "</tr>";

echo "</table>";
}



if(count($_POST)>0) 
{
$result = mysqli_query($con,"SELECT *from users WHERE name='" . $loggedin_id . "'");
$row=mysqli_fetch_array($result);
if($_POST["currentPassword"] == $row["password"] && $_POST["newPassword"] == $row["confirmPassword"] ) {
mysqli_query($con,"UPDATE users set password='" . $_POST["newPassword"] . "' WHERE name='" . $loggedin_id . "'");
$message = "Jelszó megváltoztatva";
} else{
 $message = "Helytelen jelszó";
}
}




$dbp = new mysqli("localhost","root","","users");

$sql="SELECT profpic.ID, profpic.file_name, profpic.date, profpic.status, users.ID, users.username, users.email, users.vezeteknev, users.keresztnev, users.password, users.Date FROM profpic INNER JOIN users on profpic.ID = users.ID";
//$result=mysqli_query($dbp,$sql);

$sth = $dbp->query($sql);
$result=mysqli_fetch_array($sth);
echo '<img src="img/profilkep; base64, '.base64_encode( $result['file_name'] ).'"/>';

//while($row = mysqli_fetch_array($result)){echo "<div>" . $row['file_name']. "</div>";}mysqli_close($dbp);

?>
<a href="passwordchange.php">jelszó változtatás</a>

<h4><form action="uploadprofpic.php" style ="color:white;" method="post" enctype="multipart/form-data">
    Válassz ki képet a feltöltéshez:
    <input type="file" name="file">
    <input type="submit" name="submit" value="Upload"></form></h4>

</body>
</html>