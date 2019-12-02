<?php 
	if (isset($_POST['action']) && isset($_POST['user_id'])) {
		$id= $_POST['id_remove'];
		$user_id = $_POST['user_id'];
		$cart_m->Delete_cart($id);

	
 ?>


<div class="container">
        <div class="row">
        	<div class="panel panel-primary col-md-6 col-md-offset-3">
				<h1 class="panel-heading">Remove Thành công khỏi vỏ hàng</h1>
				<form action="." method="POST">
					<input type="hidden" value="cart_view" name="action">
					<input type="hidden" value="<?php echo $user_id ?>" name="user_id">
					<button class="btn btn-danger" name="delete">
						Trở về
					</button>
				</form>
			</div>
        </div><!-- end main -->
</div>
<?php 
	}
 ?>