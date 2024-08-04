<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style/mainstyle.css">
    <title>PlanTutorial</title>
</head>
<style><?php include 'style/mainstyle.css';?></style>
<body>
<nav class="nav-sticky">
  <ul>
    <li><a href="adatok.php">Növények adatai</a></li>
    <li><a href="addplant.php">Új növény hozzáadása</a></li>
    <li><a href="profil.php">Profil</a></li>
    <li><a href="logout.php">Kijelentkezés</a></li>
  </ul>
</nav>

<header>
  <h1>PlanTutorial</h1>
</header>


<?php 
include 'dbplants.php';
$db = mysqli_connect('localhost','root','','plantutorial');

$result = mysqli_query($db,"SELECT name,leiras FROM plantutorial");

//feltöltött növények CÍMEI
echo "<table><tr>";
foreach ($result as $key => $value) {
  echo "<th>". $value['name']. "</th>";
}
echo "</tr></table>";



//oldal tartalom
foreach ($result as $key => $value)
{
  echo "<div><h2>". $value['name'] . "</h2></div>";
 echo "<div><h4>". $value['leiras'] . "</h4></div>";
}
 
?>

</body>
</html>