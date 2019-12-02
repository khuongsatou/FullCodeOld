<?php 
		$error1 = array();
		$data1 = array();
		if (!empty($_POST['login']))
		{
			$data1['mail'] = isset($_POST['mail']) ? $_POST['mail'] : '';
		    $data1['mk'] = isset($_POST['mk']) ? $_POST['mk'] : '';
			$conn=new mysqli("localhost","root","","onlineshopping");
			if ($conn->connect_error) 
			{
		    	die("Kết nối thất bại: " . $conn->connect_error);
			}

			$sql="SELECT * from user_info";
			$result=$conn->query($sql);
			
			/*if ($row = $result->fetch_assoc())
			{	
				$email=$row['email'];
		  		header("Location: user_information.php?email=$email");
			}*/
			// duyệt database nếu như giá trị truyền vào đúng với giá trị trong database thì gán lại email và chuyển trang
			while ($row = $result->fetch_assoc())
			{
				if($data1['mail']==$row['email'])
				{
					$email=$row['email'];
		  			header("Location: user_information.php?email=$email");
				}
			}
		}
 ?>