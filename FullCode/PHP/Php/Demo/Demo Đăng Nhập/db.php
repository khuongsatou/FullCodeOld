

<?php 
	global $conn;
	function connect()
	{
		global $conn;
		if (!$conn) {
			$conn = mysqli_connect("localhost","root","","quanlihoahau") or die("Không Kết nối");
			mysqli_set_charset($conn,'utf8');
			
		}
		return $conn;
		
	}

 ?>