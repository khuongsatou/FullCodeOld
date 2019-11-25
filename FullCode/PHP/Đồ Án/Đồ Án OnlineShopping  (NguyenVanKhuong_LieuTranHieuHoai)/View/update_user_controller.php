<?php 
		
		if (isset($_POST['signup'])) {
			$data  = array();
			$data['user_id']  = isset($_POST['user_id'])	? $_POST['user_id'] : '';

			$data['f_name']	  = isset($_POST['f_name'])	 	? $_POST['f_name'] 		: '';
			$data['l_name']   = isset($_POST['l_name']) 	? $_POST['l_name'] 		: '';
			$data['email'] 	  = isset($_POST['email']) 		? $_POST['email'] 		: '';
			$data['password'] = isset($_POST['password']) 	? $_POST['password'] 	: '';
			$data['mobile']   = isset($_POST['mobile']) 	? $_POST['mobile'] 		: '';
			$data['address1'] = isset($_POST['address1']) 	? $_POST['address1'] 	: '';
			$data['address2'] = isset($_POST['address2'])	? $_POST['address2'] 	: '';

			if (empty($data['f_name']) || empty($data['l_name']) || empty($data['email'])  || empty($data['password']) || empty($data['mobile']) || empty($data['address1']) || empty($data['address2']))
			{
				echo Fill_Form_View();
				echo '<button onclick="window.history.go(-1);">Trở về</button>';
			}else{

				$flag = true;
				if (!Check_FistName($data['f_name'])) {
					echo Fist_Error($data['f_name']);
					$flag= false;
					echo '<button onclick="window.history.go(-1);">Trở về</button>';
				}
				if (!Check_LastName($data['l_name'])) {
					echo Last_Error($data['l_name']);
					$flag= false;
					echo '<button onclick="window.history.go(-1);">Trở về</button>';
				}
				if (!Check_Email($data['email'])) {
					echo Email_Error($data['email']);
					$flag= false;
					echo '<button onclick="window.history.go(-1);">Trở về</button>';
				}
				if (!Check_PassWord($data['password'])) {
					echo PassWord_Error();
					$flag= false;
					echo '<button onclick="window.history.go(-1);">Trở về</button>';
				}
				if (!Check_Mobile($data['mobile'])) {
					echo Mobile_Error($data['mobile']);
					$flag= false;
					echo '<button onclick="window.history.go(-1);">Trở về</button>';
				}
?>		
<?php 		
				if ($flag) {
					$data['password'] = MaHoaMD5PassWord($data['password']);
					$user_info_m ->Update_user_info($data['user_id'],$data['f_name'],$data['l_name'],$data['email'],$data['password'],$data['mobile'],$data['address1'],$data['address2']);
					echo 'Update Thành công';
					$email=$data['email'];
 ?>
					<form action="." method="POST">
						<input type="hidden" value="user_view" name="action">
						<input type="hidden" value="<?php echo $email; ?>" name="email_login">
						<input type="hidden" value="back" name="result">
						<input type="submit" value="Về Trang User">
					</form>

 <?php 
					if (isset($_POST['result'])) {
						include './View/user_view.php';
					}
				}	
			}
		}

?> 		
