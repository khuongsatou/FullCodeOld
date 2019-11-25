<?php 
	include 'header.php';
 ?>
<?php include 'db.php'; ?> 
<?php 
	if (isset($_GET['mahh'])) {
	$mahh =$_GET['mahh'];
	$conn1 =connect();
	$result1 = mysqli_query($conn1,"SELECT * FROM `hoahau` where `MAHH`='$mahh'");
	$row1 = mysqli_fetch_array($result1);

	echo 'Hello, '.$row1['HoTen'];

	}
 ?>




 <?php 
	include 'footer.php';
 ?>