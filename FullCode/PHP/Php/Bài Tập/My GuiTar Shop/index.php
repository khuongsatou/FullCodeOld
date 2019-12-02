<?php
require "connect.php";
$q = "SELECT * FROM categories";
$result = $db->query($q);

// C1
// while ($row = $result->fetch()) {
// 	echo $row['categoryID'] . "<br>";	
// }

// C2
foreach ($result as $key => $row) {
	echo $row['categoryName'] . "<br>";
}
?>