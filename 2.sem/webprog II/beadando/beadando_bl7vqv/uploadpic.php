<?php
        include 'dbplants.php';
        $statusMsg = '';

        $targetDir = "img/";
        $fileName = basename($_FILES["file"]["name"]);
        $targetFilePath = $targetDir . $fileName;
        $fileType = pathinfo($targetFilePath,PATHINFO_EXTENSION);


        if(isset($_POST["submit"]) && !empty($_FILES["file"]["name"]))
        {

            $allowTypes = array('jpg','png','jpeg','gif','pdf');

            if(in_array($fileType, $allowTypes))
            {
                
                if(move_uploaded_file($_FILES["file"]["tmp_name"], $targetFilePath))
                {
                    
                    $insert = $dbp->query("INSERT into images (file_name, date) VALUES ('".$fileName."', NOW())");
                    if($insert)
                    {
                        $statusMsg = "Sikeres feltöltés!";
                    }
                    else
                    {
                        $statusMsg = "Feltöltés sikertelen";
                    } 
                }
            }
            else
            {
            $statusMsg = 'Csak JPG, JPEG, PNG, GIF, & PDF fájlokat tölthetsz fel.';
            }
        }
        else
        {
            $statusMsg = 'Jelöld ki a feltöltendő fájlt';
        }

        sleep(1);
        header("Location: main.php");
?>
