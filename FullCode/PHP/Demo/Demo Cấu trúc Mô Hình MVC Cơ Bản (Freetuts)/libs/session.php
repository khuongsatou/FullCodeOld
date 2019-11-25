<?php 
	
	//Gán thư viện session
	session_start();
	function session_set($key,$val)
	{
		$_SESSION[$key] =$val;
	}

	function session_get($key)
	{
		return (isset($_SESSION[$key])) ? $_SESSION[$key] :false;
	}
	//xóa session dùng cho đăng xuất
	function session_delete($key)
	{
		if (isset($_SESSION[$key])) {
			unset($_SESSION[$key]);//login
		}
	}
	
	
	

 ?>