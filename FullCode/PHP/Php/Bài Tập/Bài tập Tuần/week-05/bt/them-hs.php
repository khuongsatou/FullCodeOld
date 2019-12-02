<!DOCTYPE html>
<html>
<head>
	<title>Them hoc sinh</title>
</head>
<body>
	<form action="them-hs-submit.php" method="post">
		Ma hoc sinh: <input type="text" name="MaHocSinh">
		Ho ten: <input type="text" name="HoTen"/><br>
		Gioi tinh:
		<input type="radio" name="GioiTinh" value="1"> Nam
		<input type="radio" name="GioiTinh" value="0"> Nu
		<br>
		Ngay sinh: <input type="date" name="NgaySinh"><br>
		LopHoc: <input type="number" name="LopHoc"><br>
		Diem TB: <input type="number" name="DiemTB"><br>
		<input type="submit" name="submit" value="Them">
	</form>
</body>
</html>