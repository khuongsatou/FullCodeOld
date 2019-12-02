<?php 
	if (isset($_POST['action']) && isset($_POST['user_id'])) {
		$user_id = $_POST['user_id'];
		$product_title = $_POST['product_title'];
		$price = $_POST['price'];
		$cart = $cart_m->getCart_UserId($user_id);
		$cart_p_m = $cart_m->getCart_UserInfo_Cart($user_id);
 ?>
<div class="container">
        <div class="row">
        	<div class="panel panel-primary col-md-6 col-md-offset-3">
				<h1 class="panel-heading">Update Item Cart</h1>
				<form class="panel-body" action="." method="POST" class="form-horizontal" role="form">
		                <label>Name:</label>
						<label> <?php echo $product_title ?></label>
						<br>
						
		                <label>Quantity:</label>
		                <select name="itemqty">
		                <?php for($i = 1; $i <= 10; $i++) : ?>
		                    <option value="<?php echo $i; ?>">
		                        <?php echo $i; ?>
		                    </option>
		                <?php endfor; ?>
		                </select><br />
						<input type="hidden" name="action" value="cart_view">
						<input type="hidden" name="user_id" value="<?php echo $user_id; ?>">
						<input type="hidden" name="product_title" value="<?php echo $product_title ?>">
						<input type="hidden" name="price" value="<?php echo $price; ?>">
						<div class="form-group">
							<div class="col-sm-10 col-sm-offset-2">
								<button name="update" class="btn btn-primary">Xong</button>
							</div>
						</div>
				</form>
			</div>
            
    
        </div><!-- end main -->
    </div>

<?php 
	}
 ?>