<?php 
	
	class ob_User_info
	{
		public $user_id;
		public $first_name;
		public $last_name;
		public $email;
		public $password;
		public $mobile;
		public $address1;
		public $address2;

	    public function __construct($user_id,$first_name,$last_name,$email,$password,$mobile,$address1, $address2)
	    {
		     $this->user_id	  = $user_id;
			 $this->first_name= $first_name;
			 $this->last_name = $last_name;
			 $this->email 	  = $email;
			 $this->password  = $password;
			 $this->mobile	  = $mobile;
			 $this->address1  = $address1;
			 $this->address2  = $address2;
	    }

	   


	}

 ?>