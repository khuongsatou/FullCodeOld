<div class="col-md-12">
		<center>
			<ul class='pagination' id='pageno'>
				<?php 
					if (isset($product_cat) && isset($product_brand)) {
						$current_page = isset($_GET['page']) ? $_GET['page'] : 1;
						$total_page  = $products_m->Total_Page();
						$products_m->Previous($current_page , $total_page,$price,$product_cat,$product_brand);
						$products_m->STT($current_page , $total_page,$price,$product_cat,$product_brand);
						$products_m->NextLine($current_page , $total_page,$price,$product_cat,$product_brand);
					}
				 ?>
			</ul>
		</center>
</div>
