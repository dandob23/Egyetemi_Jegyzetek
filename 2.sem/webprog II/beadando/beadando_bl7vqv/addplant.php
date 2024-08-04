<?php 
$db = new mysqli ('localhost','root','','plantutorial');

if(isset($_POST['submit']))
{
    $errors = array();
    $true = true;
        
    if(empty($_POST['name']))
    {
        $true = false;
        array_push($errors, "Nem adtál meg a növénynek nevet!");
    }

    if(empty($_POST['place']))
    {
        $true = false;
        array_push($errors, "A származási hely nincs kitöltve!");
    }

    if(empty($_POST['color']))
    {
        $true = false;
        array_push($errors, "Nem adtál meg a színt!");
    }

    if(empty($_POST['minheat']))
    {
        $true = false;
        array_push($errors, "Nem adtál meg minimum hőmérsékletet!");
    }

    if(empty($_POST['maxheat']))
    {
        $true = false;
        array_push($errors, "Nem adtál meg maximum hőmérsékletet!");
    }

    

    if ($true)
    {
        $name = mysqli_real_escape_string($db, $_POST ['name']);
        $place = mysqli_real_escape_string($db, $_POST ['place']);
        $color = mysqli_real_escape_string($db, $_POST ['color']);
        $minheat = mysqli_real_escape_string($db, $_POST ['minheat']);
        $maxheat = mysqli_real_escape_string($db, $_POST ['maxheat']);
        $leiras = mysqli_real_escape_string($db, $_POST ['leiras']);
        

        $sql ="INSERT INTO plantutorial (name, place, color, minheat, maxheat, leiras) values ('$name','$place','$color','$minheat','$maxheat','$leiras')";
        

     if(mysqli_query($db, $sql))
    {  

        echo "Növény sikeresen hozzáadva, továbbítás a főoldalra!"; 
       
        sleep(2);
        session_start();
        header('location: main.php');

    }else
    {  
       
       echo "Error: ". mysqli_error($db);  
       
    }  
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
    <title>Új növény hozzáadás</title>
    </head>
<body>
<header>
  <h1>PlanTutorial</h1>
</header>
<h1>Új növény hozzáadása: </h1>
<h2>
<form action="addplant.php" method="POST">
        <div>A növény neve: <input type="text" name="name"/></div>
        <div>Származási hely: <input type="text" name="place"/></div>
        <div>Színe: <input type="text" name="color"/></div>
        <div>Minimum hőmérséklet (°C): <input type="number" name="minheat"/></div>
        <div>Maximum hőmérséklet (°C): <input type="number" name="maxheat"/></div>
        <div>Leírás: <input type="text" name="leiras"/></div>

        <input value="Növény feltöltése" style ="margin-left:15%" type="submit" name="submit"/></div>
 
    </form></h2>

    <h4><form action="uploadpic.php" style ="margin-left:15%" method="post" enctype="multipart/form-data">
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