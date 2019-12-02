<?php 
	include 'ob_cart.php';
	class Cart extends DataBase{
		public function __construct()
        {
            parent::getConnect();
        }
        public function __destruct()
        {
            parent::getDisconnect();
        }

        public function dbAddArray($result){
            $cart =array();
            while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
	            $id = $row['id'];
				$p_id = $row['p_id'];
				$ip_add = $row['ip_add'];
				$user_id =$row['user_id'];
				$product_title = $row['product_title'];
				$product_image = $row['product_image'];
				$qty = $row['qty'];
				$price = $row['price'];
				$total_amount = $row['total_amount'];
                array_push($cart,new ob_Cart($id,$p_id,$ip_add,$user_id,$product_title,$product_image,$qty,$price,$total_amount));
            }
            mysqli_free_result($result);
            return $cart;
        }

        public function getCart()
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM `cart`");
	        return $this->dbAddArray($result);
	   	}

        public function Insert_cart($id,$p_id,$ip_add,$user_id,$product_title,$product_image,$qty,$price,$total_amount){
	   		mysqli_query($this->conn,"INSERT INTO `cart` (`id`, `p_id`, `ip_add`, `user_id`, `product_title`, `product_image`, `qty`, `price`, `total_amount`) VALUES ('$id','$p_id','$ip_add','$user_id','$product_title','$product_image','$qty','$price','$total_amount')");
	   	}

	   	public function Delete_cart($id){
	   		mysqli_query($this->conn,"DELETE FROM `cart` WHERE `cart`.`id` ='$id'");
	   	}

	   	public function Update_cart($product_title,$qty,$total_amount){
	   		mysqli_query($this->conn,"UPDATE `cart` SET `qty` = '$qty', `total_amount` = '$total_amount' WHERE `cart`.`product_title` = '$product_title' ");
	   	}

	   	public function getCart_UserId($user_id)
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM `cart` WHERE `user_id`= '$user_id' ");
	        return $this->dbAddArray($result);
	   	}

	   	public function getCart_UserInfo_Cart($user_id)
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM `user_info`,`cart` WHERE`user_info`.`user_id`=`cart`.`user_id` AND `cart`.`user_id` = '$user_id' ");
	        return $this->dbAddArray($result);
	   	}

	   	public function getCart_UserInfo_Cart_e($email)
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM `user_info`,`cart` WHERE`user_info`.`user_id`=`cart`.`user_id` AND `user_info`.`email` = '$email' ");
	        return $this->dbAddArray($result);
	   	}




	}


 ?>