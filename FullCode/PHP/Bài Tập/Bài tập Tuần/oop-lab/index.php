<?php
include "database.php";
include "product_manager.php";
$db = new Database("localhost", "root", "", "thongtinsanpham");
$db->connect();

$productManager = new ProductManager;
$productManager->loadProduct($db);
echo $productManager;
?>