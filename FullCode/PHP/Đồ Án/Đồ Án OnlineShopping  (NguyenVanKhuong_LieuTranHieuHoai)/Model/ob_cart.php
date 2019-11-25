<?php 
	class ob_cart{
			public $id;
			public $p_id;
			public $ip_add;
			public $user_id;
			public $product_title;
			public $product_image;
			public $qty;
			public $price;
			public $total_amount;
		public function __construct($id,$p_id,$ip_add,$user_id,$product_title,$product_image,$qty,$price,$total_amount)
		{
			$this->id = $id;
			$this->p_id = $p_id;
			$this->ip_add = $ip_add;
			$this->user_id = $user_id;
			$this->product_title = $product_title;
			$this->product_image = $product_image;
			$this->qty = $qty;
			$this->price = $price;
			$this->total_amount = $total_amount;
		}






	}

 ?>