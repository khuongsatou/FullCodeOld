<?php 
    class Categories extends DataBase
    {
        public function __construct()
        {
            parent::getConnect();
        }
        public function __destruct()
        {
            parent::getDisconnect();
        }

        function getCategories()
    	{
	        $result = mysqli_query($this->conn,"SELECT * FROM categories");
	        $cat =array();
	        while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
	            $cat_id = $row['cat_id'];
	            $cat_title = $row['cat_title'];
	            $cat[$cat_id] = $cat_title;
	        }
	        mysqli_free_result($result);
	        return $cat;
    	}

    }
   


 ?>