<?php
require_once "connect.php";

try {
    $sql = "DELETE FROM MyGuests WHERE id=2";
    $conn->exec($sql);
    echo "Record deleted successfully";
} catch(PDOException $e) {
  echo $sql . "<br>" . $e->getMessage();
}

$conn = null;
?>