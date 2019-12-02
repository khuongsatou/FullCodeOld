<?php 
    function getCategories() {
        include('db_connect.php');
        $category_query="SELECT * FROM categories";
        $run_query=mysqli_query($conn,$category_query);

        $cat = array();
        while($row=mysqli_fetch_array($run_query)){
            $cid=$row['cat_id'];
            $cat_name=$row['cat_title'];
            $cat[$cid] = $cat_name;
        }
        mysqli_close($conn);
        return $cat;
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
?>

