<?php
	include "function/function.php";
	$error = array();
	$data = array();
	$flag=0;
    if (!empty($_POST['signup']))
        {
            $data['f_name'] = isset($_POST['f_name']) ? $_POST['f_name'] : '';
            $data['l_name'] = isset($_POST['l_name']) ? $_POST['l_name'] : '';
    		$data['email'] = isset($_POST['email']) ? $_POST['email'] : '';
    		$data['password'] = isset($_POST['password']) ? $_POST['password'] : '';
    		$data['mobile'] = isset($_POST['mobile']) ? $_POST['mobile'] : '';
    		$data['address1'] = isset($_POST['address1']) ? $_POST['address1'] : '';
    		$data['address2'] = isset($_POST['address2']) ? $_POST['address2'] : '';
    		//kiểm tra tên nhập vào! nếu first name hoặc last name để trống thì báo lỗi. hoặc tên có chữ số, kí tự đặc biệt thì báo lỗi 
    		if(KiemtraName($data['f_name'])==false||KiemtraName($data['l_name'])==false)
    		{
    			$error['f_name']= "Tên không đúng, ";
    			//require 'register_view.php';
    		}
    		else{
    			$flag=2;
    		}
    		//kiểm tra email có để trống ko? và có hợp lệ hay không
	    	if (empty($data['email']))
	    	{
	        	$error['email'] = ' Bạn chưa email, ';
	    	}
	    	else 
	    	{
	    		//echo "string";
	    		if (!is_email($data['email']))
	    		{
	        		$error['email'] = ' Email không đúng định dạng, ';
	    		}
	    		else{
	    			$flag++;
	    		}
	    	}
	    	//kiểm tra mk có trống không
	    	if (empty($data['password'])) {
	    		$error['password']=' chưa nhập mật khẩu, ';
	    	}
	    	//nếu không thì kiểm tra độ dài và phải bắt đầu = chữ in, có chữ số và kí tự đặc biệt
	    	else
	    	{
	    		if(KiemtraPassword($data['password'])==false)
	    		{
	    			$error['password']=' Mật khẩu không hợp lệ, ';
	    		}
	    		else
	    		{
	    			$matkhau=MahoaMD5($data['password']);
	    			//echo $matkhau;
	    			$flag++;
	    		}
	    	}
	    	//kiểm tra điện thoại nhập vào
	    	if (empty($data['mobile'])) 
	    	{
	    		$error['mobile']= ' chưa nhập điện thoại, ';
	    	}
	    	else
	    	{
	    		if(MobilePhone($data['mobile'])==false)
	    		{
	    			$error['mobile']= ' Số điện thoại không hợp lệ, ';
	    		}
	    		else
	    			$flag++;
	    	}
	    	//kiểm tra địa chỉ
	    	if (empty($data['address1'])||empty($data['address2'])) 
	    	{
	    		$error['address1'] = ' địa chỉ trống, ';
	    	}
	    	else
	    	{
	    		$flag++;
	    	}
	    	
	    	if($flag>=6)
			{
				$id=0;
				//connectDB($conn);
				$conn=new mysqli('localhost','root','','onlineshopping');
				if ($conn->connect_error) 
				{
			    	die("Kết nối thất bại: " . $conn->connect_error);
				}
				$sql1="select user_id from user_info";
				$result=$conn->query($sql1);
				//duyệt id xem có bao nhiêu id trong danh sách phần tử! sau đó gán lại và tăng thêm 1 giá trị
				while ($row=$result->fetch_assoc()) 
				{
					$id=" ".$row['user_id'];
				}
				$id++;
				$firstname=$data['f_name'];
				$lastname=$data['l_name'];
				$email=$data['email'];
				$password=$matkhau;
				$dt=$data['mobile'];
				$address1=$data['address1'];
				$address2=$data['address2'];
				$sql="INSERT into user_info (`user_id`,`first_name`,`last_name`,`email`,`password`,`mobile`,`address1`,`address2`) VALUES ('$id','$firstname','$lastname','$email','$password','$dt','$address1','$address2')";
				if ($conn->query($sql) === TRUE) {
				    echo "Thêm record thành công";
					} 
					else {
					    echo "Lỗi: " . $sql . "<br>" . $conn->error;
					}
				$conn->close();
			}
	    }

?>
				
 