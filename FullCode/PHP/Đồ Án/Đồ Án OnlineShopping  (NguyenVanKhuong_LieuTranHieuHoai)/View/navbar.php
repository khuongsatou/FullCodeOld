

<!-- Navbar header index.php -->
<div class="navbar navbar-default navbar-fixed-top" id="topnav">
		<div class="container-fluid">
			<div class="navbar-header">
				<a href="." class="navbar-brand">OnlineShopping</a>
			</div>
			<form action="." method="post">
				<input type="hidden" name="action" value="search_view">
				<ul class="nav navbar-nav">
					<li style="width:300px;left:10px;top:10px;">
						<input placeholder="Mã, Tên , Giá , Thương Hiệu Search.." type="text" class="form-control" id="search" name="search" >
					</li>
					<li style="top:10px;left:20px;"><button class="btn btn-primary" id="search_btn" name="">

						<span class='glyphicon glyphicon-search'></span></button></li>
				</ul>
			</form>
			<ul class="nav navbar-nav navbar-right">
				<li id='shoppingcart'>
					<a href="#" class="dropdown-toggle" data-toggle="dropdown"><span
							class="glyphicon glyphicon-shopping-cart"></span>Cart <span class="badge">
							<?php 
							if (isset($_COOKIE['save_email'])) {
								$save_email = $_COOKIE['save_email'];
								$cart_email = $cart_m->getCart_UserInfo_Cart_e($save_email);
								echo count($cart_email);
							}else{
								echo 0;
							} ?>
						</span>

						</a>

					<div class="dropdown-menu" style="width: 400px;">
						<div class="panel panel-success">
							<div class="panel-heading">
								<div class="row">
									<div class="col-md-3">S. No.</div>
									<div class="col-md-3">Product Image</div>
									<div class="col-md-3">Product Name</div>
									<div class="col-md-3">Price in $</div>
								</div>

							</div>
							<div class="panel-body">
								<?php 
									if (isset($_COOKIE['save_email'])) {
										$save_email = $_COOKIE['save_email'];
										$cart_email = $cart_m->getCart_UserInfo_Cart_e($save_email);	
										for ($i = 0; $i < count($cart_email) ; $i++) {
											
										
								 ?>
								 <div class="row">
									<div class="col-md-3"><?php echo $cart_email[$i]->id; ?> </div>
									<div class="col-md-3">
									<?php 
				   				 		echo '<img width=70 height="45" src="./View/assets/prod_images/';
										echo $cart_email[$i]->product_image;
										echo '">';
   				 	 				?>
   				 	 				</div>
									<div class="col-md-3"><?php echo $cart_email[$i]->product_title; ?></div>
									<div class="col-md-3">$<?php echo $cart_email[$i]->total_amount; ?></div>
									
								</div>
								 <?php } 
									}else{ ?>
									<div class="row">
										
									</div>
								<?php } ?>
								
							<div class="panel-footer"></div>
						</div>
					</div>
				</li>
<?php 

					if (isset($_COOKIE['save_email'])) {
						$save_cookie = $_COOKIE['save_email'];
						$password = null;
						$first_name = null;
						$last_name = null;
						$check = false;
	                    for ($i = 0; $i < count($user_info) ; $i++) {
	                        if ($save_cookie == $user_info[$i]->email) {
	                            $password = $user_info[$i]->password;
	                            $first_name = $user_info[$i]->first_name;  
	                            $last_name = $user_info[$i]->last_name;
	                            $check = true;
	                            break; 
	                        }
	                    }
	                    if ($check) {
	                        if ($save_cookie == 'admin@gmail.com' && $password =='c4ca4238a0b923820dcc509a6f75849b'){
	                        	#kiểm tra admin
?>								<li>	
									<form action="." method="POST">
							              <input type="hidden" value="admin_view" name="action">
							              <span class="glyphicon glyphicon-user">
							              <input style="background:none; border:none;line-height:45px;" type="submit" value="Hello,<?php echo $first_name.' '.$last_name; ?>">
									</form>
								</li>
<?php                        	
							}else{

?>
								<li>	
									<form action="." method="POST">
							              <input type="hidden" value="user_view" name="action">
							              <input type="hidden" value="<?php echo $save_cookie; ?>" name="email_login">
							              <span class="glyphicon glyphicon-user">
							              <input style="background:none; border:none;line-height:45px;" type="submit" value="Hello,<?php echo $first_name.' '.$last_name; ?>">
									</form>
								</li>


<?php							
							}

	                    }
	                    #logout
							echo '<li><a href="?logout=true">';
							echo '<span class="glyphicon glyphicon-log-out"></span> Đăng Xuất';
							echo '</a></li>';
							if (isset($_GET['logout'])) {
								setcookie('save_email','',time()-3600);
								header('location:index.php');
							}

	                }else{

?>
				
				<li><a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-user"></span>Sign In</a>
                    <ul class="dropdown-menu">
                    <div style="width: 300px;">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Login</div>
                            <div class="panel-heading">
                            <form action="." method="post">
                            	<input type="hidden" name="action" value="login_controller">
                                <label for="email">Email</label>
                                <input name="email_login" type="email" class="form-control" id="emailLogim">
                                <label for="email">Password</label>
                                <input name="password_login" type="password" class="form-control" id="passwordLogin">
                                <p><br></p>
                                <a href="#" style="color: white;list-style-type: none;">Forgot Password?</a>
                                <input type="submit" value="login" class="btn btn-success"  style="float: right;bottom:12px;" name="login">
                                 
                            </form>
                            </div>
                            <div class="panel-footer" id="e_msg"></div>
                        </div>
                    </div>
                </ul>
                </li>
                <li>
                	<form action="." method="POST">
                		<input type="hidden" name="action" value="register_view">
                		<input style="background:none; border:none;line-height:48px;" type="submit" value="Sign Up">
                	</form>
                </li>
            <?php } ?>
			</ul>
		</div>
	</div>
	<br><br><br>