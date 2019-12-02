

<div class="col-md-2">
	<div id="get_cat"></div>
	<div class="nav nav-pills nav-stacked">
		<li class="active"><a href="#"><h4>Categories</h4></a></li>
		<?php 
			foreach ($categories as $id => $value) {
			   echo '<li><a href="?product_cat='.$id;
			   echo '&page=1';
			   echo '&price=3';
			   echo Get_product().'">'; 
			   echo $value;
			   echo '</a></li>';
			}
		 ?>
	</div>
	<div id="get_brand"></div>
	<div class="nav nav-pills nav-stacked">
		<li class="active"><a href="#"><h4>Brands</h4></a></li>
		<?php 
			foreach ($brands as $id => $value) {
			   echo '<li><a href="?product_brand='.$id;
			   echo '&price=3';
			   echo '&page=1';
			   echo Get_product().'">'; 
			   echo $value;
			   echo '</a></li>';
			}
		 ?>
	</div>
</div>