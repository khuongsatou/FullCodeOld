<?php 

		if (isset($_COOKIE['luu_login'])) {
			header("location:login_tc.php?mahh={$_COOKIE['luu_login']}");
		}else{

		
?>

<form action="xuli_login.php" method="POST" role="form">
	<legend>Đăng Nhập</legend>

	<div class="form-group">
		<label for="">Mã Số</label>
		<input name="MaSo" type="text" class="form-control" id="" placeholder="">
		<label for="">Password</label>
		<input name="Password" type="password" class="form-control" id="" placeholder="">
	</div>
	<button name="submit" type="submit" class="btn btn-primary">login</button>
</form>
<?php } ?>
	