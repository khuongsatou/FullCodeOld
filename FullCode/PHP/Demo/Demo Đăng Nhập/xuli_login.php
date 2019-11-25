	<?php include 'db.php'; ?>
<?php 	
		if (isset($_POST['submit'])) {
			$MaSo = isset($_POST['MaSo']) ? $_POST['MaSo'] : '';
			$Password = isset($_POST['Password']) ? $_POST['Password'] : '';
				if (empty($MaSo) || empty($Password)) {
					header("location:login_tb.php");
				}else{
					$conn =connect();
					$result = mysqli_query($conn,"SELECT * FROM `hoahau` where `MAHH`='$MaSo' and `MatKhau` = '$Password' ");
					if (mysqli_num_rows($result)>0) {
						$row = mysqli_fetch_array($result);
						setcookie("luu_login",$row['MaHH']);
						header("location:login_tc.php?mahh={$row['MaHH']}");
					}else{
						header("location:login_tb.php");
					}
				}
			}

		
	 ?>
	
