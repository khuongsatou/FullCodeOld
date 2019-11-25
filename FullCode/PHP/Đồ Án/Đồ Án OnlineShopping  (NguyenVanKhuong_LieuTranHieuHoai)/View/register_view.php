    <div class="navbar navbar-default navbar-fixed-top" id="topnav">
        <div class="container-fluid">
            <div class="navbar-header">
                <a href="." class="navbar-brand">Online Shopping</a>
            </div>
            <ul class="nav navbar-nav navbar-right">
                <li id='shoppingcart'><a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-shopping-cart"></span>Cart <span class="badge">0</span>   </a>
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
                            <form action="." method="post">
                                <input type="hidden" name="action" value="login_controller">
                                <label for="email">Email</label>
                                <input name="email_login" type="email" class="form-control" id="emailLogin">
                                <label for="email">Password</label>
                                <input name="password_login" type="password" class="form-control" id="passwordLogin">
                                <p><br></p>
                                <a href="#" style="color: white;list-style-type: none;">Forgot Password?</a>
                                <input type="submit" value="Login" class="btn btn-success"  style="float: right;bottom:12px;" name="login">
                                 
                            </form>
                            </div>
                            <div class="panel-footer" id="e_msg"></div>
                        </div>
                    </div>
                </ul>
                </li>
                <li>    
                    <form action="." method="POST">
                          <input type="hidden" value="register_view" name="action">
                          <input style="background:none; border:none;line-height:45px;" type="submit" value="SignUp">
                    </form>
                </li>
            </ul>

        </div>
    </div>
    <p><br><br></p>
    <p><br><br></p>
    <div class="container-fluid">
        <div class="row"> 
            <div class="col-md-2"></div>
            <div class="col-md-8" id="err_msg">
                <?php 
                    if (isset($error)) {              
                        echo '<p class="error bg-warning">'.$error.'</p>';
                    }
                 ?>

            </div>
            <div class="col-md-2"></div>
        </div>
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="panel panel-primary">
                    <div class="panel-heading">Signup Form</div>
                    <div class="panel-body">
                        <form method="post" action=".">
                            <input type="hidden" name="action" value="register_controller">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="f_name">First Name(*)</label>
                                    <input onkeypress="UpdateNameFist('f_name');" type="text" id="f_name" name="f_name" class="form-control">
                                </div>
                                <div class="col-md-6">
                                    <label for="f_name">Last Name(*)</label>
                                    <input onkeypress="UpdateNameLast('l_name');" type="text" id="l_name" name="l_name" class="form-control">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-6">
                                    <label for="email">Email(*)</label>
                                    <input type="text" id="email" name="email" class="form-control">
                                </div>
                                <div class="col-md-6">
                                    <label for="password">Password(*)</label>
                                    <input type="password" id="password" name="password" class="form-control">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-6">
                                    <label for="mobile">Mobile(*)</label>
                                    <input type="text" id="mobile" name="mobile" class="form-control">
                                </div>
                                <div class="col-md-6"></div>
                            </div>

                            <div class="row">
                                <div class="col-md-12">
                                    <label for="address1">Address #1</label>
                                    <input type="textarea" id="address1" name="address1" class="form-control">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-12">
                                    <label for="address2">Address #2</label>
                                    <input type="textarea" id="address2" name="address2" class="form-control">
                                </div>
                            </div>

                            <br><br>
                            <div class="col-md-12">
                                <input type="submit" class="btn btn-primary" value="Signup" name="signup" id="signup_btn">
                            </div>
                        </form>
                    </div>
                </div>
                
                <div class="panel-footer"></div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
