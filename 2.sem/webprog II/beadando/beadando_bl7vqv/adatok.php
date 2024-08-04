<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style/adatstyle.css">
    <title>Adatok</title>
</head>
<body>

<header>
  <h1>PlanTutorial</h1>
</header>

<?php
$db = mysqli_connect('localhost','root','','plantutorial');

$result = mysqli_query($db,"SELECT * FROM plantutorial");

echo "<table border='1'>
<tr>
<th>Név</th>
<th>Hely</th>
<th>Szín</th>
<th>MinHőm</th>
<th>MaxHőm</th>
</tr>";

while($row = mysqli_fetch_array($result))
{
echo "<tr>";
echo "<td>" . $row['name'] . "</td>";
echo "<td>" . $row['place'] . "</td>";
echo "<td>" . $row['color'] . "</td>";
echo "<td>" . $row['minheat'] . "</td>";
echo "<td>" . $row['maxheat'] . "</td>";
echo "</tr>";
}
echo "</table>";

mysqli_close($db);
?>

<footer><a href="main.php">Vissza a főoldalra!</a></footer>



    
</body>
</html>