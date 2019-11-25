<?php
	include ("model/action.php");
	$categories = getCategories();
	$products = getProducts();
	include ("view/index_view.php");
?>