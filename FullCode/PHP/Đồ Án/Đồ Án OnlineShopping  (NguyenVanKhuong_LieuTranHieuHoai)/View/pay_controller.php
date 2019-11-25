<?php 
	if (isset($_POST['action']) && isset($_POST['user_id'])) {
 ?>

 <div class="container">
        <div class="row">
        	<div class="panel panel-primary col-md-6 col-md-offset-3">
				<h1 class="panel-heading">Thanh Toán Thành Công</h1>
				<form action="." method="POST">
					<input type="hidden" value="show_index" name="action">
					<button class="btn btn-danger">
						Trở về
					</button>
				</form>
			</div>
        </div><!-- end main -->
</div>

<?php } ?>
