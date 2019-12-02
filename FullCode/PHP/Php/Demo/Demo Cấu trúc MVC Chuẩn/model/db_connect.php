<?php 
	$host = 'localhost';
	$username = 'root';
	$pass = '';
	$db = 'onlineshopping';

	$conn = mysqli_connect($host,$username,$pass);
    mysqli_select_db($conn, $db);
    if (!$conn) 
		die("Connection refused").mysql_connect_error();
 ?>