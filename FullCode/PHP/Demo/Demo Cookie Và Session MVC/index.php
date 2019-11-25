<?php 
	//controller , và chạy đầu tiên
	include 'model/action.php';//copy hết những thứ trong action vào đây
	//unset($_COOKIE['email']);
	//echo $_COOKIE['email'];
	//delete bánh
	//setcookie('email','admin@gmail.com' ,time()-3600);
	//unset($_COOKIE['email']);
	$flag = false;
	if (isset($_COOKIE['email'])) {
		include 'view/login_success_view.php';
		$flag=true;
	}

	if (isset($_POST['email']) && isset($_POST['password'])) {
		$email 	  = isset($_POST['email']) ? $_POST['email'] : '';	
		$password = isset($_POST['password']) ? $_POST['password'] : '';	
		if (login($email, $password)) {
			// echo '1';
			include 'view/login_success_view.php';
			setcookie('email',$email ,time()+3600);//set trong 1h
		}else{//hiện lại nếu nhập sai
			include 'view/login_view.php';
		}
	}else{
		if ($flag) {
			
		}else{
			include 'view/login_view.php';
		}
		
	}

 ?>