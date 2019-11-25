
<!-- content-center -->
<div class="container">
<div class="col-md-12">
	<div class="row">
		<div class="col-md-12" id="cartmsg">

		</div>
	</div>
	<div class="panel panel-info">
		<div class="panel-heading text-center">--Search Result--
			<!-- <div class='pull-right'>
				Sort: &nbsp;&nbsp;&nbsp;<a href="?asc=1" id='price_sort'>Price</a> | <a href="#"
					id='pop_sort'>Popularity</a>
			</div> -->
		</div>
		
		<div class="panel-body">
			<div id="get_product"></div>
		
		<?php 
			if (isset($_POST['search'])) {
				$search = isset($_POST['search']) ? $_POST['search'] : "" ;
				$products =$products_m->Select_products_search($search);
			}

			
			for ($i = 0; $i <count($products) ; $i++) {
		 ?>
			<div style="height:400px;" class="col-md-4"><!-- medium -->
				<div style="height:100%;" class="panel panel-info">
					<div class="panel-heading">

						<?php echo $products[$i]->title; ?>
							

					</div>
					<div style="height:300px;" class="panel-body">
					
					<?php 
						echo '<img style="width: 100%;height: 100%;" class="item_img" src="./View/assets/prod_images/';
						echo $products[$i]->image;;
						echo '">';

					 ?>

					</div>
					<div class="panel-heading">
					<?php 
						echo $products[$i]->price.'$';
					 ?>
					<button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
					</div>
				</div>
			</div>

			<?php 	}
			 ?>


		</div>
		<div class="panel-footer">&copy; 2017</div>
	</div>
</div>
</div>
