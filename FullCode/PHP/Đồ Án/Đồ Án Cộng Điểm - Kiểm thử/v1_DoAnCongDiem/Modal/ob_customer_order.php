<?php 
	class ob_Customer_order{

		public $id;
		public $uid;
		public $pid;
		public $p_name;
		public $p_price;
		public $p_qty;
		public $p_status;
		public $tr_id;

		public function __construct($id,$uid,$pid,$p_name,$p_price,$p_qty,$p_status,$tr_id)
		{
			$this->id = $id;
			$this->uid = $uid;
			$this->pid = $pid;
			$this->p_name = $p_name;
			$this->p_price = $p_price;
			$this->p_qty = $p_qty;
			$this->p_status = $p_status;
			$this->tr_id = $tr_id;
		}
	}


 ?>