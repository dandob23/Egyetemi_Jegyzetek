<?php

function regUser($conn, $name, $pw){
  $sql = "INSERT INTO user (name, password)
  VALUES ('$name', '$pw')";


try {
        $conn->exec($sql);
    echo "New record created successfully" "<br>";
  } catch(PDOException $e) {
    echo $sql . "<br>" . $e->getMessage();
  }

}
?>