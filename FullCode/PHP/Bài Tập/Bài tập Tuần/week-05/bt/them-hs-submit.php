<?php
		if (isset($_POST["HoTen"])) {
			$con = mysql_connect("localhost", "root", "");
			if (!$con) {
				exit("Khong the ket noi");
			}
			mysql_select_db("qlhs", $con);
			$sql = "insert into hocsinh values ('$_POST[MaHocSinh]', '$_POST[HoTen]', '$_POST[GioiTinh]', '$_POST[NgaySinh]', '$_POST[LopHoc]', $_POST[DiemTB])";
			echo $sql;
			if (!mysql_query($sql)) {
				exit("Error: " . mysql_error());
			}

			echo  "Da them thanh cong";
			mysql_close($con);
		}
		else {
			echo "khong co du lieu trong form";
		}

	?>