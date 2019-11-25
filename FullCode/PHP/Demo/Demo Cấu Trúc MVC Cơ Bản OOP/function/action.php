<?php 
    
    //brands  theo id
    function getBrands_id($id) {
        include('db_connect.php');
        $category_query="SELECT * FROM `products` WHERE `product_brand`='$id'";
        $run_query=mysqli_query($conn,$category_query);
        return $run_query;
    }





    function getCategories() {
    include('db_connect.php');
    $category_query="SELECT * FROM categories";
    $run_query=mysqli_query($conn,$category_query);
    return $run_query;
    }

    function getBrands()
    {
    include('db_connect.php');
    $brands_query="SELECT * FROM brands";
    $run_query=mysqli_query($conn,$brands_query);
    return $run_query;
    }

    function getProducts() {
    include ("db_connect.php");
    include ("object.php");

    $product_query = "SELECT * FROM products";
    $run_query = mysqli_query($conn, $product_query);

    $products = array();
    while ($row = mysqli_fetch_array($run_query)){
        $id = $row['product_id'];
        $title = $row['product_title'];
        $price = $row['product_price'];
        $image = $row['product_image'];
        $product = new Product($id, $title, $price, $image);
        array_push($products, $product);
    }
    mysqli_close($conn);
    return $products;
    }

    function Get_product()
    {
        return '&&#get_product';
    }

    function getProductsElectronics()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=1";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getProductsLadiesWear()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=2";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getProductsMenWear()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=3";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getProductsKidsWear()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=4";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getProductsHomeAppliances()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=5";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getProductsSports()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_cat`=6";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getHP()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=1";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getSamsung()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=2";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getApple()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=3";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getSony()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=4";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getLG()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=5";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getBiba()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=6";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getFlyingMachine()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=7";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getNike()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=8";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getAdidas()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=9";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getKidzee()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=10";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getIKea()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=11";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }

    function getPhilips()
    {
        include ("db_connect.php");
        $product_query = "SELECT * FROM products where `product_brand`=12";
        $run_query = mysqli_query($conn, $product_query);

        $products = array();
        while ($row = mysqli_fetch_array($run_query)){
            $id = $row['product_id'];
            $title = $row['product_title'];
            $price = $row['product_price'];
            $image = $row['product_image'];
            $product = new Product($id, $title, $price, $image);
            array_push($products, $product);
        }
        mysqli_close($conn);
        return $products;
    }
?>

