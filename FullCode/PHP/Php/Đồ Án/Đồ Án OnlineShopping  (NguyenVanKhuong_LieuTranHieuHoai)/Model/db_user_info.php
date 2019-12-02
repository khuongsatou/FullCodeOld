<?php 
	include 'ob_user_info.php';
	class User_info extends DataBase{
	 	
	    public function __construct(){
	        parent::getConnect();
	    }
	    public function __destruct(){
	        parent::getDisconnect();
	    }

	    public function dbAddArray($result){
            $user =array();
            while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
                $id=$row['user_id'];
                $first_name=$row['first_name'];
                $last_name=$row['last_name'];
                $email=$row['email'];
                $password =$row['password'];
                $mobile = $row['mobile'];
                $address1 = $row['address1'];
                $address2 = $row['address2'];
                array_push($user,new ob_User_info($id,$first_name,$last_name,$email,$password,$mobile,$address1,$address2));
            }
            mysqli_free_result($result);
            return $user;
        }

        public function getUserInfo()
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM user_info");
	        return $this->dbAddArray($result);
	   	}

		public  function getUserInfo_UserId($user_id)
		{
			$result = mysqli_query($this->conn,"SELECT * FROM `user_info` WHERE `user_info`.`user_id` = $user_id");
	        return $this->dbAddArray($result);
		}

		public  function getUserInfo_UserId_Email($email)
		{
			$result = mysqli_query($this->conn,"SELECT * FROM `user_info` WHERE `user_info`.`email` = '$email'");
	        return $this->dbAddArray($result);
		}

		public function Select_user_info_search($search)
		{
			$sql 		= "SELECT * FROM `user_info` WHERE `user_id` LIKE '$search' OR `first_name` LIKE '$search' OR `last_name` LIKE '$search' OR `email` LIKE '$search' OR `password` LIKE '$search' OR `mobile` LIKE '$search' OR `address1` LIKE '$search' OR `address2` LIKE '$search' ";
			$result = mysqli_query($this->conn,$sql);
	        return $this->dbAddArray($result);
		}


	   	public function Insert_user_info($user_id,$first_name,$last_name,$email,$password,$mobile,$address1,$address2){
	   		mysqli_query($this->conn,"INSERT INTO `user_info` (`user_id`, `first_name`, `last_name`, `email`, `password`, `mobile`, `address1`, `address2`) VALUES ('$user_id', '$first_name', '$last_name', '$email', '$password', '$mobile', '$address1', '$address2')" );
	   	}

		public function Delete_user_id($user_id)
		{
			mysqli_query($this->conn,"DELETE FROM `user_info` WHERE `user_info`.`user_id` = $user_id" );
		}

		public function Update_user_info($user_id,$first_name,$last_name,$email,$password,$mobile,$address1,$address2)
		{
			mysqli_query($this->conn,"UPDATE `user_info` SET `first_name` = '$first_name', `last_name` = '$last_name', `email` = '$email', `password` = '$password', `mobile` = '$mobile', `address1` = '$address1', `address2` = '$address2' WHERE `user_info`.`user_id` = $user_id;");
		}
	}

 ?>