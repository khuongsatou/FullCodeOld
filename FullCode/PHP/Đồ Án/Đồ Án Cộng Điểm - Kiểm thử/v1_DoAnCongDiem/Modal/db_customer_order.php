<?php 
	include 'ob_customer_order.php';
	class Customer_Order extends DataBase{
		public function __construct()
        {
            parent::getConnect();
        }
        public function __destruct()
        {
            parent::getDisconnect();
        }

        public function dbAddArray($result){
            $Customer_order =array();
            while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
			    $id 		= $row['id'];
				$uid 		= $row['uid'];
				$pid 		= $row['pid'];
				$p_name 	= $row['p_name'];
				$p_price 	= $row['p_price'];
				$p_qty 		= $row['p_qty'];
				$p_status 	= $row['p_status'];
				$tr_id 		= $row['tr_id'];
                array_push($Customer_order,new ob_Customer_order($id,$uid,$pid,$p_name,$p_price,$p_qty,$p_status,$tr_id));
            }
            mysqli_free_result($result);
            return $Customer_order;
        }

        public function getCustomerOrder()
	   	{
	   		$result = mysqli_query($this->conn,"SELECT * FROM `customer_order`");
	        return $this->dbAddArray($result);
	   	}

        public function Insert_Customer_Order($id,$u_id,$p_id,$p_name,$p_price,$p_qty,$p_status,$tr_id){
	   		mysqli_query($this->conn,"INSERT INTO `customer_order` (`id`, `uid`, `pid`, `p_name`, `p_price`, `p_qty`, `p_status`, `tr_id`) VALUES ($id,$u_id,$p_id,$p_name,$p_price,$p_qty,$p_status,$tr_id);");
	   	}

	}

 ?>