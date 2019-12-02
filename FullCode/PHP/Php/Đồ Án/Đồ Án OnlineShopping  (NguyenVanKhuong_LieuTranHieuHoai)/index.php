<?php 
	ob_start();
	// xử lí modal
	include 'Model/action.php';
	#khởi tạo
	$categories_m = new Categories();
	$brands_m 	  = new Brands();
	$products_m   = new Products();
	$user_info_m  = new User_info();
	$cart_m 	  = new Cart();
	$customer_order_m = new Customer_Order();
	#gọi phương thức
	$categories   = $categories_m->getCategories();
	$brands 	  = $brands_m->getBrands();
	$products 	  = $products_m->getProductsAll();
	$user_info	  = $user_info_m ->getUserInfo();
	$cart 		  = $cart_m->getCart();
	$customer_order = $customer_order_m->getCustomerOrder();
	#xử lí view
	include './View/header.php';
	$action 	  = "show_index";
	if (isset($_POST['action'])) {
		$action   = $_POST['action'];
		//echo $action;
	}
	switch ($action) {
		case 'show_index':
			include './View/index.php';
			//echo var_dump($products);
			break;
		case 'search_view':
			include './View/navbar.php';
			include './View/search_view.php';
			break;
		case 'register_view':
			include './View/register_view.php';
			break;
		case 'register_controller':
			include './View/register_controller.php';
			break;
		case 'login_controller':
			include './View/login_controller.php';
			break;	
		case 'update_user_view':
			include './View/update_user_view.php';
			break;
		case 'update_user_controller':
			include './View/update_user_controller.php';
			break;
		case 'admin_view':
			include './View/admin_view.php';
			break;
		case 'product_details_view':
			include './View/navbar.php';
			include './View/product_details_view.php';
			break;
		case 'user_view':
			include './View/user_view.php';
			break;
		case 'cart_view':
			include './View/navbar.php';
			include './View/cart_view.php';
			break;
		case 'cart_view_controller':
			include './View/navbar.php';
			include './View/cart_view_controller.php';
			break;
		case 'cart_view_update':
			include './View/navbar.php';
			include './View/cart_view_update.php';
			break;
		case 'pay_view':
			include './View/navbar.php';
			include './View/pay_view.php';
			break;
		case 'pay_view':
			include './View/navbar.php';
			include './View/pay_view.php';
			break;
		case 'pay_controller':
			include './View/navbar.php';
			include './View/pay_controller.php';
			break;
		default:
			echo '404 not found';
			break;
	}
	include './View/footer.php';
 ?>