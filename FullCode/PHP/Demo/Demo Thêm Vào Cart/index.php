<?php 
	include 'db_action.php';
	$products = getProducts();

	$cart = array();
	$id_select = "";
	$quality ="";
	if (isset($_POST['productkey'])) {
		$id_select = $_POST['productkey'];
		$quality   = $_POST['itemqty'];
		$item = array();
		$item['name'] = $products[$id_select]['name'];
		$item['cost'] = $products[$id_select]['cost'];
		$item['quanlity'] = $quality;
		$cart[$id_select] = $item;
	}
	
	$action = "show_item";
	if (isset($_POST['submit'])) {
		$action = "cart_view";
	}
	switch ($action) {
		case "show_item":
			include 'add_item_view.php';
			break;
		case "cart_view":
			include 'cart_view.php';
			break;
		default:
			include 'index.php';
			break;
	}
	

 ?>