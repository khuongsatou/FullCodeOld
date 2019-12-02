
<?php 		
		
		if (isset($_POST['action'])) {
			$data  = array();
			$data['email_login'] 	= isset($_POST['email_login'])	? $_POST['email_login'] : '';
			$data['password_login'] = isset($_POST['password_login']) ? $_POST['password_login'] : '';
			if (empty($data['email_login']) || empty($data['password_login']))
			{
				echo '<legend>Điền Đầy Đủ email và pass</legend>';
				echo '<form action="." method="POST">';
		    	echo '<input type="hidden" value="register_view" name="action">';
		    	echo '<button class="btn btn-default">Trở về</button>';
		    	echo '</form>';
?>
	

<?php				
			}else{
				#kiểm tra email đúng định dạng k
				if (!Check_Login_email($data['email_login'])) {
					echo '<legend>Đăng Nhập Thất Bại Hãy Kiểm tra Lại Email Và Password</legend>';
					echo '<form action="." method="POST">';
		    		echo '<input type="hidden" value="register_view" name="action">';
		    		echo '<button class="btn btn-default">Trở về</button>';
		    		echo '</form>';
				}else{#đúng
					
					$data['password_login'] = MaHoaMD5PassWord($data['password_login']);

					$check = false;
                    for ($i = 0; $i < count($user_info) ; $i++) {
                        if ($data['email_login'] == $user_info[$i]->email && $data['password_login'] == $user_info[$i]->password) {
                            $check = true;   
                            break;
                        }
                    }
                    if ($check) {
						   if ($data['email_login'] == 'admin@gmail.com' && $data['password_login'] =='c4ca4238a0b923820dcc509a6f75849b') {

						   		setcookie('save_email',$data['email_login'],time()+3600);
						   		include './View/admin_view.php';
						   }else{
						   	   	setcookie('save_email',$data['email_login'],time()+3600);
					   			include './View/user_view.php';
					  		}
                    }else{
                       		echo '<legend>Sai Email Hoặc Password or Không tồn Tại</legend>';
							echo '<form action="." method="POST">';
					    	echo '<input type="hidden" value="register_view" name="action">';
					    	echo '<button class="btn btn-default">Trở về</button>';
					    	echo '</form>';
                    }
				}
				
			}

		}

 ?>
