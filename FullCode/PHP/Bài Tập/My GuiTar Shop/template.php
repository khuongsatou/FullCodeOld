<?php 
    require 'connect.php';


    //$sql = "SELECT `productCode`,`productName` FROM `products`";
    //$result = $db->query($sql);
 ?>




<!DOCTYPE html>
<html>
    <!-- the head section -->
    <head>
        <title>My Guitar Shop</title>
        <link rel="stylesheet" type="text/css" href="main.css" />
    </head>

    <!-- the body section -->
    <body>
    <div id="page">
        <div id="main">
        
        <a style="text-decoration: none;" href="template.php"><h1>Product List</h1></a>
        
        <div id="sidebar">
            <!-- display a list of categories -->
            <h2>Categories</h2>
            <ul class="nav">
                <?php 
                    $sql_cate  = "SELECT * FROM `categories`";
                    $result_cate = $db->query($sql_cate);
                    foreach ($result_cate as $row) {
                        
                   

                 ?>
                <li>
                    <a href="?category_id=<?php echo $row['categoryID']; ?>"><?php echo $row['categoryName']; ?></a>
                </li>
                <?php  } ?>
            </ul>
        </div>

        <div id="content">
            <!-- display a table of products -->
            <?php 
                if (isset($_GET['category_id'])) {
                    $category_id = $_GET['category_id'];
                    $sql = "SELECT `productCode`,`productName`,`listPrice` FROM `products` WHERE categoryID=$category_id ";
                    $result = $db->query($sql);

                }else{
                    $sql = "SELECT `productCode`,`productName`,`listPrice` FROM `products` ";
                    $result = $db->query($sql);
                }



             ?>
            <h2>Guitars</h2>

            <table>
                <tr>
                    <th>Code</th>
                    <th>Name</th>
                    <th class="right">Price</th>
                </tr>
                <?php 
                    foreach ($result as $row) {
                     


                 ?>
                <tr>
                    <td><?php echo $row['productCode']; ?></td>
                    <td><?php echo $row['productName']; ?></td>
                    <td class="right"><?php echo $row['listPrice']; ?></td>
                </tr>
                
                <?php } ?>
            </table>
        </div>
        </div><!-- end main -->
        <div id="footer"></div>
    </div><!-- end page -->
    </body>
</html>