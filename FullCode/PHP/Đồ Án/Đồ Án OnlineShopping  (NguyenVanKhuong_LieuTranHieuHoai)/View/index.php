
<!-- Navbar -->
 <?php include './View/navbar.php'; ?>
	<!-- Slider Begins -->

	<div class="container-fluid one-time">
		<div class="row"><img class="col-md-12" src="./View/assets/images/car1.jpg"></div>
		<div class="row"><img class="col-md-12" src="./View/assets/images/car2.jpg"></div>
		<div class="row"><img class="col-md-12" src="./View/assets/images/car3.jpg"></div>
	</div>

	<!-- Slider ends -->

	<br>
	<div class="container-fluid">
		<div class="row">
			<div class="col-md-1"></div>
			<?php include './View/aside_left.php'; ?>
			<?php include './View/content_center.php'; ?>
			<div class="col-md-1"></div>
		</div>
		<div class="row">
			<?php include './View/pagination.php'; ?>

			<!-- Modal -->
			<?php include './View/modal.php'; ?>
			

			<!-- Modal ends-->
		</div>
	</div>


