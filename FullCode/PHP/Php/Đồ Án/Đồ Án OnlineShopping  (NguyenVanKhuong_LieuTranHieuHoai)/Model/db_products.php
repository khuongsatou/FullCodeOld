<?php 
	include 'ob_product.php';
	class Products extends DataBase
	{
        public function __construct()
        {
        	parent::getConnect();
        }
         public function __destruct()
        {
            parent::getDisconnect();
        }



        public function dbAddArray($result)
        {
            $products =array();
            while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)) {
                $id=$row['product_id'];
                $cat=$row['product_cat'];
                $brand=$row['product_brand'];
                $title=$row['product_title'];
                $price=$row['product_price'];
                $desc=$row['product_desc'];
                $image=$row['product_image'];
                $keywords=$row['product_keywords'];

                array_push($products,new ob_Product($id,$cat,$brand,$title,$price,$desc,$image,$keywords));
            }
            mysqli_free_result($result);
            return $products;
        }

        public function getProductsAll()
        {
            $result = mysqli_query($this->conn,"SELECT * FROM `products`");
            return  $this->dbAddArray($result);
        }

        public function getProducts($start,$limit)
        {
            $result = mysqli_query($this->conn,"SELECT * FROM `products` LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

        public function getProducts_ASC($start,$limit)
        { 
             $result = mysqli_query($this->conn,"SELECT * FROM `products` ORDER BY `product_price` ASC LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

        public function getProducts_DESC($start,$limit)
        {
             $result = mysqli_query($this->conn,"SELECT * FROM `products` ORDER BY `product_price` DESC LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

         public function getProductsCategoriesBrand($product_cat,$product_brand,$start,$limit)
        {
            $result = mysqli_query($this->conn,"SELECT * FROM `products` WHERE `product_cat`= '$product_cat' OR `product_brand`='$product_brand' LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

         public function getProductsCategoriesBrand_ASC($product_cat,$product_brand,$start,$limit)
        {
             $result = mysqli_query($this->conn,"SELECT * FROM `products` WHERE `product_cat`= '$product_cat' OR `product_brand`='$product_brand'  ORDER BY `product_price` ASC LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

        public function getProductsCategoriesBrand_DESC($product_cat,$product_brand,$start,$limit)
        {
             $result = mysqli_query($this->conn,"SELECT * FROM `products` WHERE `product_cat`= '$product_cat' OR `product_brand`='$product_brand' ORDER BY `product_price` DESC LIMIT $start,$limit");
            return  $this->dbAddArray($result);
        }

        # search
        public  function Select_products_search($search)
        {
            $result = mysqli_query($this->conn,"SELECT * FROM `products` WHERE `product_id` like '$search' OR `product_title` like '%$search%' OR `product_price` like '$search' OR `product_desc`like '$search' OR `product_keywords` like '%$search%'");
            return  $this->dbAddArray($result);
        }

        # Phân Trang
        public function Total_records()
        {
            $result = mysqli_query($this->conn,"SELECT count(`product_id`) as total FROM `products`");
            if (isset($_GET['product_cat'])) {
                $product_cat = $_GET['product_cat'];
                $result = mysqli_query($this->conn,"SELECT count(`product_id`) as total FROM `products` WHERE `product_cat` = $product_cat");
            }else if (isset($_GET['product_brand'])) {
                $product_brand = $_GET['product_brand'];
                $result = mysqli_query($this->conn,"SELECT count(`product_id`) as total FROM `products` WHERE `product_brand` = $product_brand");
            }
            $row    = mysqli_fetch_assoc($result); 
            $total_records= $row['total'];//value
            mysqli_free_result($result);
            return $total_records;
        }


        public function Limit_Count()
        {
            return 6;
        }


        public function Check_Current_page($current_page,$total_page)
        {
            if ($current_page > $total_page) {
                $current_page = $total_page;
            }else if($current_page < 0){
                $current_page = 1;
            }
            return $current_page;
        }

        public function Total_Page()
        {
            $total_records = $this->Total_records();
            $limit = $this->Limit_Count();
            return ceil($total_records / $limit);
        }

        public function Start_Position($current_page)
        {
            //tính toán total_page và start
            $total_page  =$this->Total_Page();
            $current_page =$this->Check_Current_page($current_page,$total_page);
            if ($current_page <= 0) {
                $current_page = 1;
            }
            $start = ($current_page -1 ) * $this->Limit_Count();
            return $start;
        }


        public  function Cat_exists()
        {
            return isset($_GET['product_cat']) ? true : false;
        }

        public function Brand_exists()
        {
            return isset($_GET['product_brand']) ? true : false;
        }

        public function Previous($current_page , $total_page, $price,$product_cat, $product_brand)
        {
            if ($current_page > 1 && $total_page >1) {
                if ($this->Cat_exists()) {
                    echo '<li><a href="?product_cat='.$product_cat.'&&page='.($current_page-1).'&&price='.$price.'&&'.'#content-product'.'"> << </a></li>';
                }else if ($this->Brand_exists()){
                    echo '<li><a href="?product_brand='.$product_brand.'&&page='.($current_page-1).'&&price='.$price.'&&'.'#content-product'.'"> << </a></li>';
                }else{
                    echo '<li><a href="?page='.($current_page-1).'&&price='.$price.'&&'.'#content-product'.'"> << </a></li>';
                }
            }else{
                echo '<li><span> << </span></li>';
            }
        }

        public function STT($current_page , $total_page , $price , $product_cat, $product_brand)
        {
            for ($i = 1; $i <= $total_page; $i++) {
                if ($current_page == $i) {
                    echo '<li><span> '.$i.' </span></li>';
                }else{
                    if ($this->Cat_exists()) {
                        echo '<li><a href="?product_cat='.$product_cat.'&&page='.$i.'&&price='.$price.'#content-product'.'"> '.$i.' </a></li>';
                    }else if ($this->Brand_exists()) {
                        echo '<li><a href="?product_brand='.$product_brand.'&&page='.$i.'&&price='.$price.'#content-product'.'"> '.$i.' </a></li>';
                    }else{
                        echo '<li><a href="?page='.$i.'&&price='.$price.'#content-product'.'"> '.$i.' </a></li>';
                    }
                    
                }

            }
        }

        public function NextLine($current_page , $total_page, $price,$product_cat, $product_brand)
        {
            if ($current_page < $total_page && $total_page >1) {
                if ($this->Cat_exists()) {
                    echo '<li><a href="?product_cat='.$product_cat.'&&page='.($current_page+1).'&&price='.$price.'&&'.'#content-product'.'"> >> </a></li>';
                }else if ($this->Brand_exists()){
                    echo '<li><a href="?product_brand='.$product_brand.'&&page='.($current_page+1).'&&price='.$price.'&&'.'#content-product'.'"> >> </a></li>';
                }else{
                    echo '<li><a href="?page='.($current_page+1).'&&price='.$price.'&&'.'#content-product'.'"> >> </a></li>';
                }
            }else{
                echo '<li><span> >> </span></li>';
            }
        }
	}

 ?>