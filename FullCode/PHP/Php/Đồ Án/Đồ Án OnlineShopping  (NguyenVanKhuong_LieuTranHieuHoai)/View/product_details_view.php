<div class="container">
<div class="row">
<?php 
	if (isset($_POST['id'])) {
		$get_id = $_POST['id']-1;

 ?>
			
			<h1 class="col-md-12"><?php echo $products[$get_id]->title; ?></h1>
			<div class="col-md-12">
				<ol class="breadcrumb">
				<li>
					<a href="#">Home</a>
				</li>
				<li>
					<a href="#">A</a>
				</li>
					<li class="active">B</li>
				</ol>
			</div>
			 <div class="col-sm-4 col-md-6">
   				 <div class="thumbnail">
   				 	<?php 
   				 		echo '<img style="width: 100%;height: 100%;" class="item_img" src="./View/assets/prod_images/';
						echo $products[$get_id]->image;
						echo '">';
   				 	 ?>
     		 		<!-- <img src="./View/img/trangchu/ao.jpg" alt="..."> -->
   			 	</div>
		 	 </div><!-- Thumbnail -->
			 <div class="col-sm-8 col-md-6">
			 	
			 	<legend class="col-md-offset-2">Mô Tả Sản Phẩm</legend>
   			 		<dl class="dl-horizontal">
 					  <dt>Giá:</dt>
 					  <h1><dd><del><?php echo ($products[$get_id]->price)*(1.1); ?>$</del><br><strong style="color:red;" >$<?php echo $products[$get_id]->price; ?></strong></dd></h1>

 					  <dt>Brands:</dt>
 					  <dd><p><?php echo $brands[$products[$get_id]->brand]; ?></p></dd>

 					   <dt>Categories:</dt>
 					  <dd><p><?php echo $categories[$products[$get_id]->cat]; ?></p></dd>
						
					  <form action="." method="POST">
	 				  <dt>Quantity:</dt><dd>	
	                	<select name="itemqty">
		                <?php 
		                   for ($i = 1; $i <=10 ; $i++) {
		                        echo '<option value="'.$i.'">
		                              '.$i.'
		                                </option>';
		                    }
	                 	?>
	                	</select></dd> <br />

 					  <dt>Mô Tả:(DESC):</dt>
 					  <dd><p><?php echo $products[$get_id]->desc; ?></p>
 					  		
							Thích hợp với các bạn nữ tự sướng.
					  </dd>
					
			<?php 
				if (isset($_COOKIE['save_email'])) {
					$get_userIDCurrent = $user_info_m->getUserInfo_UserId_Email($_COOKIE['save_email']);
					$user_id 		   = $get_userIDCurrent[0]->user_id;
					$price 			   = $products[$get_id]->price;
					$product_title 	   = $products[$get_id]->title;
					$product_image 	   = $products[$get_id]->image;
			 ?>	
					<!-- Truyền 3 cái thôi OK -->	
					<input type="hidden" name="action" value="cart_view">
					<input type="hidden" name="p_id" value="<?php echo $get_id+1; ?>">
					<input type="hidden" name="user_id" value="<?php echo $user_id; ?>">
					<input type="hidden" name="price" value="<?php echo $price; ?>">
					<input type="hidden" name="product_title" value="<?php echo $product_title; ?>">
					<input type="hidden" name="product_image" value="<?php echo $product_image; ?>">
					<input type="submit" name="addCart" value="Thêm Vào giỏ" class="btn btn-success pull-right">
					</form>

			<?php 
				}else{
			 ?>
				<form action="." method="POST">
					<input type="hidden" name="action" value="register_view">
					<input type="submit" name="addCart" value="Thêm Vào giỏ" class="btn btn-success pull-right">
					</form>
				</form>	
			<?php } ?>

						

					</dl>
   			 </div><!-- Mô tả -->
 <?php } ?>
   	 
</div><!-- row -->

		<div class="row">
			<ul class="nav nav-tabs">
 				<li role="presentation" class="active"><a href="#">Thông Tin Thêm Về Sản Phẩm</a></li>
				<li role="presentation"><a href="#">Bình Luận</a></li>
  				<li role="presentation"><a href="#">ReView(0)</a></li>
			</ul>	
			<p class="col-md-12">
				-Thiết kế tay dàicó nón,mang đến phong cách trẻ trung,năng động. <br>
				-Dây khóa kéo cao có thể che được phần cổ giúp bạn bảo vệ cổ khỏi nắng nóng hoặc không khí lạnh khi đi ra ngoài đường.<br>
				-Đường chỉ viền áo rất thời trang, phối túi tiện dụng giúp bạn đựng được những vật nhỏ cần thiết
				-Gam màu dễ lựa chọn và dễ dàng kết hợp trang phục khác nhau.<br>
				-Chất liệu dù mềm mại,thoáng mát, thấm hút mồ hôi tốt, không hầm bí,mang lại cảm giác thoải mái khi mặc.
				-Kết hợp với các item như: váy, đầm; sơ mi,túi xách... để giúp nàng luôn thanh lịch; trẻ trung.<br>
				-5 tông màu cho các bạn tha hồ lựa chọn nhé: Đỏ - Đen - Xanh rêu - Xám trắng và Xám đậm.
				-OneSize dưới 60kg.<br>				
			</p>
			<img src="./View/img/trangchu/ao_1.jpg" class="img-responsive" alt="Image">
			<p> Cách phối màu áo tương phản càng làm tăng thêm sự quyến rũ, mạnh mẽ của người mặc. bạn cũng có thể mặc đi chơi, dạo phố, picnic</p>
			<img src="./View/img/trangchu/ao_2.jpg" class="img-responsive" alt="Image">
			<img src="./View/img/trangchu/ao_3.jpg" class="img-responsive" alt="Image">
			<p>. Lưu ý áo kèm túi hai bên, giúp bạn xỏ tay khi trời nóng, lạnh hoặc đựng vật dụng cần thiết</p>
			<img src="./View/img/trangchu/ao_4.jpg" class="img-responsive" alt="Image">
		</div><!-- row -->
	</div>