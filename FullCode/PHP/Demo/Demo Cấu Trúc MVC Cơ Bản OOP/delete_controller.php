<?php 
	$id=$_GET['user_id'];
	$adminURL = 'Admin.php';
	$conn=new mysqli("localhost","root","","onlineshopping");
		if ($conn->connect_error) {
			die("kết nối thất bại: ". $conn->connect_error);
			}
	$sql="DELETE FROM user_info where `user_id`='$id'";
		if ($conn->query($sql)===true) 
		{
			header('Location: '.$adminURL);
		}
		else{
			echo "FAILED".$conn->error();
		}
 ?>