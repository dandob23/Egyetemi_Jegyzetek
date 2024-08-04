<?php 
$elso = "Hello World!";

$masodik = "Egy,Kettő,Három";
$tomb=explode(',',$masodik);

function hello(){
    echo "hello world"; 
};

function sum($a, $b){
    return $a+$b;
};

function sum2($a, $b){
    $a=$_GET['a'];
    $b=$_GET['b'];
    return $a+$b;
};
?>