<?php 
	function KiemtraName($dulieu1)
	{
		$partent="/^[a-zA-Z ]*$/";
		if (empty($dulieu1))
    		{
	        	return false;
	    	}
	    else 
	    {
	    	return (!preg_match($partent,$dulieu1))?FALSE:TRUE;
    	}
	}

	function KiemtraPassword($password)
	{
		$partent="/^([A-Z]){1}([\w_\.!@#$%^&*()]+){5,31}$/";
		if(strlen($password)>=6)
		{
			return (!preg_match($partent, $password))?FALSE:TRUE;
		}
	}

	function is_email($str) 
	{
    	return (!preg_match("/^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$/ix", $str)) ? FALSE : TRUE;
	}

	function MahoaMD5($password)
	{
		return md5($password);
	}

	function MobilePhone($mobile)
	{
		$partent="/^[0]{1}([0-9])/";
		if(strlen($mobile)>=9&&strlen($mobile)<13)
		{
			return (!preg_match($partent,$mobile))?FALSE:TRUE;
		}
	}
 ?>