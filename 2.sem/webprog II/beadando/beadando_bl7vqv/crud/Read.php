<?php

function logUser($conn, $name, $pw)
{
  $sql = "SELECT id, name FROM user WHERE name = '$name' AND password = '$pw'";


try 
{
  $stmt = $conn->prepare($sql);
  $stmt->execute();
  $log = array();

  foreach($stmt->fetchAll() as $k=>$v)
  {
    $log[0] = $v['id'];
    $log[1] = $v['name'];

    echo "<br>";
  }

  return $log;
} catch(PDOException $e) 
{
  echo "Error: " . $e->getMessage();
}
}

function listTitles($conn, $id)
{
  $sql = "SELECT id, name FROM list WHERE user_id = '$id'";
  
  try 
  {
    $stmt = $conn->prepare($sql);
    $stmt->execute();
  
    $log = array();
  
    return $stmt;
  } catch(PDOException $e) 
  {
    echo "Error: " . $e->getMessage();
  }
}
?>