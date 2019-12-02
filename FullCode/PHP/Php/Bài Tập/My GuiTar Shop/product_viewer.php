<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
</head>
<body>
	
<?php 
	require 'connect.php';


	$sql = "SELECT `productCode`,`productName` FROM `products`";
	$result = $db->query($sql);
	//$row = $result->fetch();

	echo '<table border="1">';
	echo '<tr>';
	echo '<th>';
		echo 'productCode';
	echo '</th>';
	echo '<th>';
		echo 'productName';
	echo '</th>';
	echo '</tr>';

	
	
	foreach ($result as $row) {
		echo '<tr>';
		echo '<td>';
			echo $row['productCode'];
		echo '</td>';
		echo '<td>';
			echo $row['productName'];
		echo '</td>';	
		echo '</tr>';
	}
	echo '</table>';
	
	
 ?>
	
</body>
</html>

