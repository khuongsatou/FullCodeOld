<!DOCTYPE html>
<html>
<head>
	<title>Thông tin tài khoản</title>
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
	<div class="col-md-2"></div>
	<div class="col-md-8">
		<div class="panel panel-default">
			<div class="panel-heading">
				<h3 class="panel-title" style="text-align: center;">Thông tin tài khoản</h3>
			</div>
			<div class="panel-body">
					<table class='table table-hover'>
						<thead>
							<tr>
								<th>user_id</th>
								<th>first_name</th>
								<th>last_name</th>
								<th>email</th>
								<th>password</th>
								<th>mobile</th>
								<th>address1</th>
								<th>address2</th>
								<th>Khác</th>
							</tr>
						</thead>
					<tbody>


			<?php 
			$conn = new mysqli("localhost","root","","onlineshopping");
			if ($conn->connect_error) 
			{
		    	die("Kết nối thất bại: " . $conn->connect_error);
			}
			if (isset($_GET['email'])) {
					$email = $_GET['email'];
					$sql="SELECT * FROM user_info where `email` = '$email'";
					$result=$conn->query($sql);
				while ($row = $result->fetch_assoc()) {
							echo "<tr>";
								echo "<td>".$row['user_id']."</td>";
								echo "<td>".$row['first_name']. "</td>";
								echo "<td>".$row['last_name']."</td>";
								echo "<td>".$row['email']."</td>";
								echo "<td>".$row['password']."</td>";
								echo "<td>".$row['mobile']."</td>";
								echo "<td>".$row['address1']."</td>";
								echo "<td>".$row['address2']."</td>";
								echo "<td>";
								echo '<a href="update_controller.php?email='.$row['email'].'&user_id=';
								echo $row['user_id'];
								echo '">';
								echo 'EDIT</a>';
								echo "</td>";
								
							echo "</tr>";
				}

			}
				$conn->close();
			 ?>
					</tbody>
				</table>		
			</div>
		</div>
	</div>
</body>
</html>