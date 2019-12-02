<?php 
	function connect_db()
	{
		
			$conn = mysqli_connect("localhost","root","","quanlisanpham") or die("Không Kết nối");
			mysqli_set_charset($conn,'utf8');
		
		return $conn;
	}

	function select_sanpham()
	{
		$conn = connect_db();
		$result = mysqli_query($conn,"SELECT * FROM `sanpham`");
		return $result;
	}
	function select_sanpham_tensp($tensp)
	{
		$conn = connect_db();
		$result = mysqli_query($conn,"SELECT * FROM `sanpham` 	WHERE `TenSp`= '$tensp' ");
		return $result;
	}
	function select_sanpham_gia($x,$y)
	{
		$conn = connect_db();
		$result = mysqli_query($conn,"SELECT * FROM `sanpham` 	WHERE `Gia` >= $x AND `Gia` <= $y  ");
		return $result;
	}
	function insert_sanpham($tensp,$gia)
	{
		$conn = connect_db();
		mysqli_query($conn,"INSERT INTO `sanpham` (`MaSP`, `TenSp`, `Gia`) VALUES (NULL, '$tensp', '$gia')");
		
	}




 ?>