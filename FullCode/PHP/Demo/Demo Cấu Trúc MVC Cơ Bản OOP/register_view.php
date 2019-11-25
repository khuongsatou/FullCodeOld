<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Amaclone</title>
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-3.3.6-dist/css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="styles.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script type="text/javascript" src="//cdn.jsdelivr.net/jquery.slick/1.6.0/slick.min.js"></script>
    <script src="assets/bootstrap-3.3.6-dist/js/bootstrap.min.js"></script>
    <script src="main.js"></script>
</head>

<body>
    <div class="navbar navbar-default navbar-fixed-top" id="topnav">
        <div class="container-fluid">
            <div class="navbar-header">
                <a href="index.php" class="navbar-brand">Online Shopping</a>
            </div>
            <ul class="nav navbar-nav navbar-right">
				<li id='shoppingcart'><a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-shopping-cart"></span>Cart <span class="badge">0</span>	</a>
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
							<div class="panel-body"></div>
							<div class="panel-footer"></div>
						</div>
					</div>
				</li>
				<li><a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-user"></span>Sign In</a>
					<ul class="dropdown-menu">
					<div style="width: 300px;">
						<div class="panel panel-primary">
							<div class="panel-heading">Login</div>
							<div class="panel-heading">
                                
                                <form method="post" action="register_view.php">
    								<label for="email">Email</label>
    								<input type="email" class="form-control" id="email" name="mail" value="<?php echo isset($data1['mail']) ? $data1['mail'] : ''; ?>">
    								<label for="email">Password</label>
    								<input type="password" class="form-control" id="password" name="mk" value="<?php echo isset($data1['mk']) ? $data1['mk'] : ''; ?>">
    								<span>
                                    <?php 
                                        include "login_controller.php";
                                        echo isset($error1['mail']) ? $error1['mail'] : '';
                                    ?>
                                    </span>
                                    <p></p>
    								<a href="#" style="color: white;list-style-type: none;">Forgot Password?</a>
    								<input type="submit" class="btn btn-success" style="float: right;bottom:12px;" id="login" value="Login" name="login">
                                </form>
							</div>
							<div class="panel-footer" id="e_msg"></div>
						</div>
					</div>
				</ul>

				<li><a href="register_view.php">Sign Up</a></li>
			</ul>

        </div>
    </div>
    <p><br><br></p>
    <p><br><br></p>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8" id="err_msg">
                <div class="panel panel-danger">
                    <div class="panel-heading">
                        <?php 
                            include "register_controller.php";
                            echo isset($error['f_name']) ? $error['f_name'] : '';
                            echo isset($error['email']) ? $error['email'] : ''; 
                            echo isset($error['password']) ? $error['password'] : '';
                            echo isset($error['mobile']) ? $error['mobile'] : '';
                            echo isset($error['address1']) ? $error['address1'] : '';
                        ?>                        
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="panel panel-primary">
                    <div class="panel-heading">Signup Form</div>
                    <div class="panel-body">
                        <form method="post" action="register_view.php">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="f_name"><span style="color:red;">*</span>First Name</label>
                                    <input type="text" id="f_name" name="f_name" class="form-control" value="<?php echo isset($data['f_name']) ? $data['f_name'] : ''; ?>">
                                </div>
                                <div class="col-md-6">
                                    <label for="f_name"><span style="color:red;">*</span>Last Name</label>
                                    <input type="text" id="l_name" name="l_name" class="form-control" value="<?php echo isset($data['l_name']) ? $data['l_name'] : ''; ?>">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-6">
                                    <label for="email"><span style="color:red;">*</span>Email</label>
                                    <input type="text" id="email" name="email" class="form-control" value="<?php echo isset($data['email']) ? $data['email'] : ''; ?>">
                                </div>
                                <div class="col-md-6">
                                    <label for="password"><span style="color:red;">*</span>Password</label>
                                    <input type="password" id="password" name="password" class="form-control" value="<?php echo isset($data['password']) ? $data['password'] : ''; ?>">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-6">
                                    <label for="mobile"><span style="color:red;">*</span>Mobile</label>
                                    <input type="text" id="mobile" name="mobile" class="form-control"
                                    value="<?php echo isset($data['moblie']) ? $data['mobile'] : ''; ?>">
                                </div>
                                <div class="col-md-6"></div>
                            </div>

                            <div class="row">
                                <div class="col-md-12">
                                    <label for="address1"><span style="color:red;">*</span>Address #1</label>
                                    <input type="textarea" id="address1" name="address1" class="form-control" value="<?php echo isset($data['address1']) ? $data['address1'] : ''; ?>">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-12">
                                    <label for="address2">Address #2</label>
                                    <input type="textarea" id="address2" name="address2" class="form-control" value="<?php echo isset($data['address2']) ? $data['address2'] : ''; ?>">
                                </div>
                            </div>

                            <br><br>
                            <div class="col-md-12">
                                <input type="submit" class="btn btn-primary" value="Signup" name="signup" id="signup_btn">
                            </div>

                    </div>
                </div>
                </form>
                <div class="panel-footer"></div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
    </div>

    
</body>
<div class="foot">
    <footer>
        <p> Medium Project <a href="https://google.com/">PHP Web Programming</a></p>
        <p><b>Your name</b></p>
        <p> Kmin and Code-project</p>
    </footer>
</div>
<style>
    .foot {
        text-align: center;
    }
</style>

</html>