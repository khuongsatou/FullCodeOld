
<?php 
	
	if (isset($_POST['action']) && isset($_POST['user_id']))  {
		$p_id 				= null;
		$ip_add				= null;
		$user_id			= $_POST['user_id'];
		$product_title 		= null;
		$product_image 		= null;
		$qty  				= null;
		$price  			= null;
		$total_amount 		= null;
		$id = null;//lấy toàn bộ id cart
		if (!isset($_POST['delete'])) {
			if (!isset($_POST['update'])) {
				$p_id 				= $_POST['p_id'];
				$ip_add				= "0.0.0.0";
				$user_id			= $_POST['user_id'];
				$product_title 		= $_POST['product_title'];
				$product_image 		= $_POST['product_image'];
				$qty  				= $_POST['itemqty'];
				$price  			= $_POST['price'];
				$total_amount 		= $price*$qty;

				// Fix lỗi ID
				$luu_id =0;
				$isCheck = false;
				for ($i = 0; $i < count($cart); $i++) {
					if ($cart[$i]->id != ($i+1)) {
						$luu_id = ($i+1);
						$isCheck= true;
						break;
					}
				}
				if ($isCheck) {
					$id = $luu_id;

				}else{
					$id = count($cart)+1;//lấy toàn bộ id cart
				}

			}
		}
		$cart_p_user 		= $cart_m->getCart_UserInfo_Cart($user_id);


			
 ?>


<p><br><br></p>
<p><br><br></p>

<div class="container-fluid">
		<div class="row">
			<div class="col-md-2"></div>
			<div class="col-md-8">
			<div class="row">
				<div class="col-md-12" id="cart_msg"></div>
			</div>
				<div class="panel panel-primary text-center">
					<div class="panel-heading">Cart Checkout</div>
					<div class="panel-body"></div>
					<div class="row">
						<div class="col-md-2"><b>Action</b></div>
						<div class="col-md-2"><b>Product Image</b></div>
						<div class="col-md-2"><b>Product Name</b></div>
						<div class="col-md-2"><b>Product Price</b></div>
						<div class="col-md-2"><b>Quantity</b></div>
						<div class="col-md-2"><b>Price in $</b></div>
					</div>
					<?php 	


				if (isset($_POST['addCart']) || isset($_POST['delete']) || isset($_POST['update'])) {
					
					if (isset($_POST['addCart'])) {
						$cart_p_user 		= $cart_m->getCart_UserInfo_Cart($user_id);//kết bảng và trả về
						//Insert lần đầu thì không cần kiểm tra trùng và lúc đó kết bảng sẽ rỗng toàn bộ
						if ($cart_p_user != null) {//có 1 cart đã thêm rồi
							$check = false;
							for ($i = 0; $i < count($cart_p_user); $i++) {
								if ($p_id == $cart_p_user[$i]->p_id) {//nếu trùng thì không insert nữa
									$check = true;
									break;
								}
							}

							if (!$check) {//không trùng thì insert
								$cart_m->Insert_cart($id,$p_id,$ip_add,$user_id,$product_title,$product_image,$qty,$price,$total_amount);
								$cart_p_user 		= $cart_m->getCart_UserInfo_Cart($user_id);//cập nhật lại
							}else{//nếu nó trùng nhau thì select lại thôi

							}

						}else{//nếu null thì insert vào luôn
							$cart_m->Insert_cart($id,$p_id,$ip_add,$user_id,$product_title,$product_image,$qty,$price,$total_amount);
							$cart_p_user 		= $cart_m->getCart_UserInfo_Cart($user_id);//cập nhật lại
						}
					}

					if (isset($_POST['update'])) {
						$product_title 		= $_POST['product_title'];
						$qty  				= $_POST['itemqty'];
						$price  			= $_POST['price'];
						$total_amount 		= $price*$qty;
						$cart_m->Update_cart($product_title,$qty,$total_amount);
						$cart_p_user 		= $cart_m->getCart_UserInfo_Cart($user_id);
					}

					$sum = 0;	
					for ($i = 0; $i < count($cart_p_user) ; $i++) {
							$sum +=$cart_p_user[$i]->total_amount;
	
					 ?>

					<br><br>
					<div id='cartdetail'>
					<div class="row">
							<div class="col-md-2">
								<span>
								<form class="col-md-1" action="." method="POST">
									<input type="hidden" value="cart_view_controller" name="action">
									<input type="hidden" value="<?php echo $cart_p_user[$i]->id; ?>" name="id_remove">
									<input type="hidden" value="<?php echo $cart_p_user[$i]->user_id; ?>" name="user_id">
									<button class="btn btn-danger" name="delete">
										<span class="glyphicon glyphicon-trash"></span>
									</button>
							 	
						 		</form>
						 		</span>

						 		<span>
						 		<form style="margin-left:20px" class="col-md-1" action="." method="POST">
									<input type="hidden" value="cart_view_update" name="action">
									<!-- <input type="hidden" value="<?php //echo $cart_p_user[$i]->id; ?>" name="id_update"> -->
									<input type="hidden" value="<?php echo $cart_p_user[$i]->user_id; ?>" name="user_id">
									<input type="hidden" value="<?php echo $cart_p_user[$i]->product_title; ?>" name="product_title">
									<input type="hidden" value="<?php echo $cart_p_user[$i]->price; ?>" name="price">
									<button class="btn btn-success" name="update">
										<span class="glyphicon glyphicon-ok-sign"></span>
									</button>

									
								</form>
								</span>
							</div>

				


						<div class="col-md-2">

					<?php 
   				 		echo '<img width="60px" height="60px" src="./View/assets/prod_images/';
						echo $cart_p_user[$i]->product_image;
						echo '">';
   				 	 ?>
							


						</div>
						<div class="col-md-2"><?php echo $cart_p_user[$i]->product_title; ?></div>
						<div class="col-md-2">$<?php echo $cart_p_user[$i]->price; ?></div>
						<div class="col-md-2"><input class="form-control" type="text" size="10px" value='<?php echo $cart_p_user[$i]->qty; ?>'></div>
						<div class="col-md-2"><input class="form-control" type="text" size="10px" value='<?php echo $cart_p_user[$i]->total_amount; ?>'></div>
						

					</div>
					</div>
				<?php }
				 ?>
					<div class="row">
						<div class="col-md-8"></div>
						<div class="col-md-4">
							<b>Total: $<?php echo $sum; ?></b>
						</div>
					</div>
		<?php  } ?>	
					<div class="panel-footer">
						
					</div>
				</div>
				<form action="." method="POST">
					<input type="hidden" value="pay_view" name="action">
					<input type="hidden" value="<?php echo $user_id; ?>" name="user_id">
					<button name="check_out" class='btn btn-success btn-lg pull-right' id='checkout_btn' data-toggle="modal" data-target="#myModal">Checkout</button>
				</form>
			</div>
				
			<div class="col-md-2"></div>
		</div>
	</div>
<?php } ?>

