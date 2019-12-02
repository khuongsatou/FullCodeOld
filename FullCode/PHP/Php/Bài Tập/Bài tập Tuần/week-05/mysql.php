Lam demo: 5.2 4.2
<?php
	// Mo Ket noi CSDL
	// Neu ket noi khong thanh cong thi tra ve NULL
	$con = mysql_connect("localhost", "root", "");
	if (!$con) {
		$error = mysql_error();
		exit("Khong the ket noi. Loi " . $error);
	}

	mysql_select_db("persons", $con);
	// Xu ly, truy van
	$result = mysql_query("SELECT * FROM Persons");
	while ($row = mysql_fetch_array($result)) {
		echo $row['FirstName'] . " - " . $row['Age'] . "<br>";
	}

	// Dong ket noi
	mysql_close($con);
?>