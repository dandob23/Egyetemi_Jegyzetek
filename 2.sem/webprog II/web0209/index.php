<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>web0209</title>
</head>
<body>
    <h1>Programozó bácsii! </h1>

    <?php 
        $elso = "Programozó bácsi in PHP";
        const konstans = "Én nem változok!";
        
        
    ?>

    <?php 

        echo "<p>",konstans,"<p>";
    
    ?>

    <ul>
        <?php 
            for($i=0; $i<=5; $i++)
            {
                echo "<li> Nagy gáz van ".$i."</i>";
            }
        ?>

    </ul>

    <ul>
        <?php 
            for($i=0; $i<=5; $i++){?>
            <li>Még mindig gáz van <?php echo $i;?></li>
            <?php } ?>
    </ul>

</body>
</html>