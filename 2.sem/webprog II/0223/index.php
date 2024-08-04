<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <?php 
    include "kulso.php"; 
    ?>
    <title>feladat</title>
</head>
<body>
    <?php 
        //echo $elso, "<br>";
        //echo $tomb[1], "<br>";

        //hello();
        //echo "<br>";

       // echo sum(3,7);
        //echo "<br>";
       // echo sum2();


        $age = array (
            "Péter" =>34, "Béla" =>19, "Rezső" =>23, "Zsuzsa"=>41, "Elek"=>17
        );

        foreach ($age as $key => $value) {
            echo $key. " ".$value." éves.<br>";
        }

        $time = new DateTime('NOW');
        echo $time->format('Y.m.d H:i:s');

        $time = new DateTime('1879-03-14');
        $age = $time -> diff(new DateTime('NOW'))->format('%y');
        echo "<br>";
        echo "Einstein ma ".$age." éves lenne! :O";

        $age = $time -> diff(new DateTime('NOW'))->format('%y éve, %m hónapja, és %d napja született!');
        echo "<br>";
        echo $age;
        echo "<br>";
        echo file_exists('include.php');
        echo "<br>";

        $myfile = fopen ("test.txt", "a");

        $txt = "John Doe\n";
        fwrite($myfile, $txt);
        fclose($myfile);

        $myfile = fopen("test.txt", "r");
        echo "<br>";
        echo fread ($myfile, filesize ("test.txt"));

    ?>
</body>

</html>