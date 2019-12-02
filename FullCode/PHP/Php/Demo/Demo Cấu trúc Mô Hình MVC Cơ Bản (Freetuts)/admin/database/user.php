<?php 

	function db_user_get_by_username($username)
	{
		$username = addslashes($username);
		$sql = "SELECT * FROM `tb_user` where `username` = '$username'";
		return db_get_row($sql);
	}

	function db_user_validate($data)
	{
		$error = array();

		if (isset($data['username']) && $data['username'] == '') {
			$error['username'] = 'Bạn chưa nhập tên đăng nhập';
		}
		if (isset($data['email']) && $data['email'] =='') {
			$error['email'] = 'Bạn chưa nhập email';
		}
		if (isset($data['email']) && filter_var($data['email'],FILTER_VALIDATE_EMAIL) === false) {
			$error['email'] = 'Email không hợp lệ';
		}
		if (isset($data['password']) && $data['password'] =='') {
			$error['password'] = 'Bạn chưa nhập password';
		}
		if (isset($data['password'])  && isset($data['re-password']) && $data['password'] != $data['re-password']) {
			$error['re-password'] = 'Mật Khẩu nhập lại không đúng';
		}
		if (isset($data['level']) && !in_array($data['level'], array('1','2'))) {
			$error['level'] ='Level bạn chọn không tồn tại';
		}

		if (!($error) && isset($data['username']) && $data['username']) {
			$sql = "SELECT count(id) as counter FROM tb_user WHERE username ='".addslashes($data['username'])."'";
			$row = db_get_row($sql);
			if ($row['counter'] > 0) {
				$error['username'] ='Tên đăng nhập này đã tồn tại';
			}
		}

		if (!($error) && isset($data['email']) && $data['email']) {
			$sql = "SELECT count(id) as counter FROM tb_user WHERE email='".addslashes($data['email'])."'";
        	$row = db_get_row($sql);
       	    if ($row['counter'] > 0){
            	$error['email'] = 'Email này đã tồn tại';
       		}
		}

		return $error;

	}



 ?>