<!DOCTYPE html>
<html>
<head>
	<title>Insert Form</title>
</head>
<body>
	<form action="" method="post">
		Firstname: <input type="text" name="fname"><br>
		Lastname: <input type="text" name="lname"><br>
		Age: <input type="number" name="age"><br>
		<input type="submit" value="Sign up">
	</form>

	<?php
		$fname = $_POST['fname'];
		$lname = $_POST['lname'];
		$age = $_POST['age'];

		$con = mysql_connect("localhost", "root", "");
		mysql_select_db("my_db", $con);
		mysql_query("insert into persons values('$fname', '$lname', '$age')", $con);
		mysql_close($con);
	?>
</body>
</html>