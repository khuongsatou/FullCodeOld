<!DOCTYPE html>
<html>
<head>
	<title>Danh sach hoc sinh</title>
</head>
<body>
	<?php
		$con = mysql_connect("localhost", "root", "");
		if (!$con) {
			exit("Ket noi khong thanh cong" . mysql_error()); 
		}

		mysql_select_db("qlhs", $con);
		$result = mysql_query("SELECT * FROM HocSinh");
		while ($row = mysql_fetch_array($result)) {
			echo $row['MaHocSinh'] . ": " . $row["HoTen"] . "<br>";
		}

		mysql_close();
	?>
</body>
</html>