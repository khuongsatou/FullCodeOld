<?php 
	$dsn  = 'mysql:host=localhost;dbname=my_guitar_shop1';
	$username = 'root';
	$password = '';
	$db = new PDO($dsn,$username,$password) or die("Chết rồi ");

 ?>