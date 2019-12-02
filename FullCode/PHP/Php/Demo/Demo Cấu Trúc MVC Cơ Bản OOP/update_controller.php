<head>
	<title>Cập nhật thông tin tài khoản</title>
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
	<div class="col-md-2"></div>
		<div class="col-md-8">
	<div class="panel panel-info">
				<div class="panel-heading">
					<h3 class="panel-title">Cập nhật thông tin</h3>
				</div>
				<div class="panel-body">
					<form action="?user_id=<?php echo $_GET['user_id']; ?>" method="POST" role="form">
						<div class="row">
							<div class="col-md-6">
								<label for="">first name</label>
								<input type="text" class="form-control" id="" name="frname">
							</div>
							<div class="col-md-6">
								<label for="">last name</label>
								<input type="text" class="form-control" id="" name="laname" >
							</div>
						</div>
						<div class="row">
							<div class="col-md-6">
								<label for="">password</label>
								<input type="password" class="form-control" id="" name="m_k">
							</div>
							<div class="col-md-6">
								<label for="">mobile</label>
								<input type="text" class="form-control" id="" name="DT">
							</div>
						</div>
						<br>
						<button name="submit" type="submit" class="btn btn-primary">Submit</button>
					</form>
					
				</div>
	</div>
</body>
<?php 
				include "function/function.php";
				if(isset($_POST['submit']))
				{
					$fn=$_POST['frname'];
					$ln=$_POST['laname'];
					$pass=MahoaMD5($_POST['m_k']);
					$mobi=$_POST['DT'];
					$id=$_GET['user_id'];
					$conn=new mysqli("localhost","root","","onlineshopping");
					if ($conn->connect_error) {
					die("kết nối thất bại: ". $conn->connect_error);
					}
					$sql="UPDATE user_info SET `first_name`='$fn',`last_name`='$ln',`password`='$pass',`mobile`='$mobi' where `user_id`='$id'";
					if ($conn->query($sql)===true) {
					echo "<h1 style='color:green;'>update success</h1>";
					}
					else{
						echo "FAILED".$conn->error();
					}
				}
 ?>