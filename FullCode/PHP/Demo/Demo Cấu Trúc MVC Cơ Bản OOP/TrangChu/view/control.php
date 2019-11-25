<?php 
	include ("./../../function/action.php");
	$categories = getCategories();
	$brands=getBrands();
	$products = getProducts();
	$Electronics=getProductsElectronics();
	$LadiesWear=getProductsLadiesWear();
	$MensWear=getProductsMenWear();
	$KidsWear=getProductsKidsWear();
	$HomeAppliances=getProductsHomeAppliances();
	$Sports=getProductsSports();

	$HP=getHP();
	$Samsung=getSamsung();
	$Apple=getApple();
	$Sony=getSony();
	$LG=getLG();
	$Biba=getBiba();
	$FlyingMachine=getFlyingMachine();
	$Nike=getNike();
	$Adidas=getAdidas();
	$Kidzee=getKidzee();
	$Ikea=getIKea();
	$Philips=getPhilips();
 ?>