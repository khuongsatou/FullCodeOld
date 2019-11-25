<?php 

	//register
	function Fill_Form_View()
	{
		$error ="Please fill a fields!";
		return $error;
	}

	function Fist_Error($name)
	{
		$error = $name." is Not a Name valid!";
		return $error;
	}
	function Last_Error($name)
	{
		$error = $name." is Not a Name valid!";
		return $error;
	}

	function Email_Error($email)
	{
		$error = $email." is Not a email valid!";
		return $error;
	}

	function PassWord_Error()
	{
		$error ="Please enter a password with at least 6 characters, including at least 1 uppercase and at least 1 special character";
		return $error;
	}

	function Mobile_Error($mobile)
	{
		$error = $mobile." is not a mobile valid!";
		return $error;
	}


	function Check_FistName($f_name)
	{
		$pattern = '/^[A-z]+$/';
		return preg_match($pattern, $f_name) ? true : false;
	}

	function Check_LastName($l_name)
	{
		$pattern = '/^[A-z| ]+$/';//tính luôn trường hợp nhiều từ cách nhau
		return preg_match($pattern, $l_name) ? true : false;
	}

	function Check_Email($email)
	{
		$pattern = '/^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/';
		return preg_match($pattern, $email) ? true : false;
	}

	function Check_Mobile($mobile)
	{
		$pattern = '/((03|05|07|08)+([0-9]{8})\b)/';//03 56241963
		return preg_match($pattern, $mobile) ? true : false;
	}

	function Check_PassWord($password)
	{
		$patternChuHoa 	='/[A-Z]+/';
		$patternSpecial ='/[^A-z0-9]+/';
		return preg_match($patternChuHoa, $password) && preg_match($patternSpecial, $password) ? true : false;
	}

	//login
	function Check_Login_email($email)
	{
		if (Check_Email($email)) {
			return true;
		}
		return false;
		
	}

	function MaHoaMD5PassWord($pass)
	{
		return md5($pass);
	}

	function Get_product()
	{
		return '&#get_product';
	}

	// function Check()
	// {
	// 	$check = false;
 //        for ($i = 0; $i < count($mang) ; $i++) {
 //            if ($data['email_login'] == $user_info[$i]->email) {
 //                $check = true;   
 //                break;
 //            }
 //        }
 //        if ($check) {
			  
 //        }else{
           		
 //        }
	// }
	


 ?>

