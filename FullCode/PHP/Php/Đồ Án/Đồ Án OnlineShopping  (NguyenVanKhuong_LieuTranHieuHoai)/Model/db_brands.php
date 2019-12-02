<?php 
	class Brands extends DataBase
    {
        public function __construct()
        {
            parent::getConnect();
        }
        public function __destruct()
        {
            parent::getDisconnect();
        }

        function getBrands()
    	{
	        $result = mysqli_query($this->conn,"SELECT * FROM brands");
	        $brand =array();
	        while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
	            $brand_id = $row['brand_id'];
	            $brand_title = $row['brand_title'];
	            $brand[$brand_id] = $brand_title;
	        }
	        mysqli_free_result($result);
	        return $brand;
    	}

    }
   

 ?>