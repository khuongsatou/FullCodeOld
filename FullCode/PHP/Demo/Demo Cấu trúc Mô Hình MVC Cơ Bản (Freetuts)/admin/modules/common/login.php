<?php 
	$error = array();
	//session_delete('ss_user_token');
	if (is_admin()) {
		redirect(base_url('admin/?m=common&a=dashboard'));
	}

	if (is_submit('login')) {
		$username = input_post('username');
		$password = input_post('password');
		if (empty($username)) {
			$error['username'] ='Bạn chưa nhập Tài Khoản';
		}
		if (empty($password)) {
			$error['password'] ='Bạn chưa nhập mật khẩu';
		}
		if (!$error) {
			include_once 'database/user.php';
			$user =db_user_get_by_username($username);
			if (empty($user)) {
				$error['username'] ='tên đăng nhập không đúng';
			}
			else if ($user['password'] != md5($password)) {
				$error['password'] = "Mật khẩu sai";
			}
			if (!$error) {
				set_logged($user['username'] ,$user['level']);
				redirect(base_url('admin/?m=common&a=dashboard'));
			}
		}
	}

 ?>

<?php include_once('widgets/header.php'); ?>
<h1>Trang đăng nhập!</h1>
<form method="post" action="<?php echo base_url('admin/?m=common&a=login'); ?>">
    <table>
        <tr>
            <td>Username</td>
            <td><input type="text" name="username" value=""/></td>
            <?php show_error($error,'username'); ?>
            <input type="hidden" name="request_name" value="login">
        </tr>
        <tr>
            <td>Password</td>
             <?php show_error($error,'password'); ?>
            <td><input type="password" name="password" value=""/></td>
        </tr>
        <tr>
            <td></td>
            <td><input type="submit" name="login-btn" value="Đăng nhập"/></td>
        </tr>
    </table>
</form>
<?php include_once('widgets/footer.php'); ?>