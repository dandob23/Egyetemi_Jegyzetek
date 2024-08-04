<?php 
include('session.php');
include('dbprof.php');
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

//$dbpr = new mysqli("localhost","root","","plantutorial");

//$sql="SELECT * FROM images WHERE file_name like '%.jpg'";
//$result=mysqli_query($dbpr,$sql);

//while($row = mysqli_fetch_array($result))
//{
//echo "<div>" . $row['file_name']. "</div>";
//}
//mysqli_close($dbpr);
?>

</body>
</html>