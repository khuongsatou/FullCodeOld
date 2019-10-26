<?php 
	//thư viện kiểm tra
	//đăng nhập
	function set_logged($username,$level)//login
	{
		 session_set(
		 	'ss_user_token',array(
		 		'username'=>$username,
		 		'level'=>$level
		 ));//tryền key và value
	}
	
	//đăng xuất
	function set_logout()
	{
		session_delete('ss_user_token');
	}

	//người dùng
	function is_logged()
	{
		$user = session_get('ss_user_token');
		return $user;
	}

	//admin
	function is_admin()
	{
		$user = is_logged();
		if (!empty($user['level']) && $user['level'] =='1') {
			return true;
		}
		return false;
	}

	function get_current_username()
	{
		$user = is_logged();
		return isset($user['username']) ? $user['username'] : '';
	}
	function get_current_level()
	{
		$user = is_logged();
		return isset($user['level']) ?  $user['level'] : '';
	}

	// Hàm kiểm tra là supper admin
	function is_supper_admin(){
	    $user = is_logged();
	    if (!empty($user['level']) && $user['level'] == '1' && $user['username'] == 'Admin'){
	        return true;
	    }
	    false;
	}


 ?>