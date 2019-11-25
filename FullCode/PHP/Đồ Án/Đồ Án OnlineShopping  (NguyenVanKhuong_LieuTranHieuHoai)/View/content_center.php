<!-- content-center -->
<div class="col-md-8">
	<div class="row">
		<div class="col-md-12" id="cartmsg">

		</div>
	</div>
	<div class="panel panel-info">
		<div id="get_product"></div>
		<div id="content-product" class="panel-heading text-center">--Featured Products--
			<div class='pull-right'>
				Sort: &nbsp;&nbsp;&nbsp;
				<?php 
					$product_cat = isset($_GET['product_cat']) ? $_GET['product_cat'] : "";
					$product_brand = isset($_GET['product_brand']) ? $_GET['product_brand'] : "";
					echo '<a href="?price=1';
					//kiểm tra xem có hông
					if (!empty($product_cat)) {
						echo '&product_cat='.$product_cat;
					}
					if (!empty($product_brand)){
						echo '&product_brand='.$product_brand;
					}
					echo Get_product();
					echo '" id="price_sort" >';
					echo 'Price Thấp</a> |';
				 ?>

				 <?php 
				 	echo '<a href="?price=2';
					//kiểm tra xem có hông
					if (!empty($product_cat)) {
						echo '&product_cat='.$product_cat;
					}
					if (!empty($product_brand)){
						echo '&product_brand='.$product_brand;
					}
					echo Get_product();
					echo '" id="price_sort" >';
					echo 'Price Cao</a> |';
				  ?>
				  
				 <?php 
				 	echo '<a href="?price=3';
					//kiểm tra xem có hông
					if (!empty($product_cat)) {
						echo '&product_cat='.$product_cat;
					}
					if (!empty($product_brand)){
						echo '&product_brand='.$product_brand;
					}
					echo Get_product();
					echo '" id="price_sort" >';
					echo 'Popularity</a> |';
				  ?>
			</div>
		</div>
		
		<div class="panel-body">
			
		
		<?php 
			$current_page = isset($_GET['page']) ? $_GET['page'] : 1;
			$start 	  = $products_m->Start_Position($current_page);
			$limit	  = $products_m->Limit_Count();
			$price 	  = isset($_GET['price']) ? $_GET['price'] : 3;
			if (isset($_GET['product_cat']) || isset($_GET['product_brand'])) {
				//đã có categories
				$product_cat  = isset($_GET['product_cat']) ? $_GET['product_cat'] : "";
				$product_brand = isset($_GET['product_brand']) ? $_GET['product_brand'] : "";

				if ($price == 1) {
					$products = $products_m->getProductsCategoriesBrand_ASC($product_cat,$product_brand,$start,$limit);
				}else if($price == 2){
					$products = $products_m->getProductsCategoriesBrand_DESC($product_cat,$product_brand,$start,$limit);
				}else{
					$products = $products_m->getProductsCategoriesBrand($product_cat,$product_brand,$start,$limit);
				}
			}else{
				if ($price == 1) {
					$products = $products_m->getProducts_ASC($start,$limit);
				}else if($price == 2){
					$products = $products_m->getProducts_DESC($start,$limit);
				}else{
					$products = $products_m->getProducts($start,$limit);
				}
			}
			for ($i = 0; $i < count($products) ; $i++) {
		 ?>
			<div style="height:400px;" class="col-md-4"><!-- medium -->
				<div style="height:100%;" class="panel panel-info">
					<div class="panel-heading">

						<?php echo $products[$i]->title; ?>
							

					</div>
					<form action="." method="POST">
						<input type="hidden" name="action" value="product_details_view">
						<input type="hidden" name="id" value="<?php echo $products[$i]->id; ?>">
						<button style="background:none; border:none;line-height:45px;">
						<div style="height:300px;" class="panel-body">
						<?php 

							echo '<img style="width: 100%;height: 100%;" class="item_img" src="./View/assets/prod_images/';
							echo $products[$i]->image;
							echo '">';

						 ?>
						</div>
						</button>
					</form>
					<div class="panel-heading">
					<?php 

						echo $products[$i]->price.'$';
						
					 ?>
					 <?php 
					 if (isset($_COOKIE['save_email'])) {
						$get_userIDCurrent = $user_info_m->getUserInfo_UserId_Email($_COOKIE['save_email']);
						$get_id = $products[$i]->id;
						$user_id 		   = $get_userIDCurrent[0]->user_id;
						$price 			   = $products[$i]->price;
						$product_title 	   = $products[$i]->title;
						$product_image 	   = $products[$i]->image;
					  ?>
					<form action="." method="POST">
						<input type="hidden" name="action" value="cart_view">
						<input type="hidden" name="itemqty" value="1">
						<input type="hidden" name="p_id" value="<?php echo $get_id; ?>">
						<input type="hidden" name="user_id" value="<?php echo $user_id; ?>">
						<input type="hidden" name="price" value="<?php echo $price; ?>">
						<input type="hidden" name="product_title" value="<?php echo $product_title; ?>">
						<input type="hidden" name="product_image" value="<?php echo $product_image; ?>">
						<button name="addCart" class="btn btn-danger btn-xs" style="float:right;">Add to cart</button>
					</form>
					  <?php }else{ ?>
					<form action="." method="POST">
						<input type="hidden" name="action" value="register_view">
						<button class="btn btn-danger btn-xs" style="float:right;">Add to cart</button>
					</form>
					<?php } ?>
						
					</div>
				</div>
			</div>

			<?php 
				}
			 ?>


		</div>
		<div class="panel-footer">&copy; 2017</div>
	</div>
</div>