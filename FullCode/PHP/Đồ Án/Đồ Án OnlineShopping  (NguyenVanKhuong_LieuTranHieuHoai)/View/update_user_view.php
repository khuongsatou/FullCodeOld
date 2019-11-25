<?php 
        if (isset($_POST['g_email'])) {
            $email =$_POST['g_email'];
            $check = false;
            for ($i = 0; $i < count($user_info) ; $i++) {
                if ($email == $user_info[$i]->email) {
                    $check = true;
                    break;   
                }
            }
            if ($check) {
                

	
			
		

 ?>	
<div class="container-fluid">
    <div class="row"> 
        <div class="col-md-2"></div>
        <div class="col-md-8" id="err_msg">
           

        </div>
        <div class="col-md-2"></div>
    </div>
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="panel panel-primary">
                <div class="panel-heading">Update Profile</div>
                <div class="panel-body">
                    <form method="post" action=".">
                        <div class="row">
                            <div class="col-md-6">
                                <input name="action" type="hidden" value="update_user_controller">
                                <input name="user_id" type="hidden" value="<?php echo $user_info[$i]->user_id; ?>">

                                <label for="f_name">First Name(*)</label>
                                <input value="<?php echo $user_info[$i]->first_name; ?>" onkeypress="UpdateNameFist('f_name');" type="text" id="f_name" name="f_name" class="form-control">
                            </div>
                            <div class="col-md-6">
                                <label for="f_name">Last Name(*)</label>
                                <input value="<?php echo $user_info[$i]->last_name; ?>" onkeypress="UpdateNameLast('l_name');" type="text" id="l_name" name="l_name" class="form-control">
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label for="email">Email(*)</label>
                                <input value="<?php echo $user_info[$i]->email; ?>" type="email" id="email" name="email" class="form-control">
                            </div>
                            <div class="col-md-6">
                                <label for="password">Password(*)</label>
                                <input value="" type="password" id="password" name="password" class="form-control">
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label for="mobile">Mobile(*)</label>
                                <input value="<?php echo $user_info[$i]->mobile; ?>" type="text" id="mobile" name="mobile" class="form-control">
                            </div>
                            <div class="col-md-6"></div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <label for="address1">Address #1</label>
                                <input value="<?php echo $user_info[$i]->address1; ?>" type="textarea" id="address1" name="address1" class="form-control">
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <label for="address2">Address #2</label>
                                <input value="<?php echo $user_info[$i]->address2; ?>" type="textarea" id="address2" name="address2" class="form-control">
                            </div>
                        </div>

                        <br><br>
                        <div class="col-md-12">
                            <input type="submit" class="btn btn-primary" value="Update" name="signup" id="signup_btn">
                        </div>
                    </form>
                    <button style="margin:15px;" class="btn btn-primary" onclick="window.history.go(-1);">Trở về</button>
                </div>
            </div>
            
            <div class="panel-footer"></div>
        </div>
    </div>
    <div class="col-md-2"></div>
</div>	

<?php 
		}
	}
 ?>