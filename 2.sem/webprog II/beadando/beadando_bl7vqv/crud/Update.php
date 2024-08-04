<?php
require_once "connect.php";

try 
{

  $sql = "UPDATE user SET nev='Doe' WHERE id=2";
  $stmt = $conn->prepare($sql);
  $stmt->execute();

 
  echo $stmt->rowCount() . " records UPDATED successfully";
}
 catch(PDOException $e) 
{
  echo $sql . "<br>" . $e->getMessage();
}

$conn = null;
?>