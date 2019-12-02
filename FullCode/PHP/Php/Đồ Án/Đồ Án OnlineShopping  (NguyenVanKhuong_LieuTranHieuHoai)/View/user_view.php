
<?php 
      if (isset($_POST['action']) || isset($_POST['email_login'])) {
          $email_login = isset($_POST['email_login']) ? $_POST['email_login'] :  $data['email_login'];
          for ($i = 0; $i < count($user_info); $i++) {
             if ($email_login == $user_info[$i]->email) {
                  
           


         
             
 ?>
    <nav class="navbar navbar-inverse">
      <div class="container-fluid">
        <div class="navbar-header">

          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>

          <a class="navbar-brand" href=".">Hồ Sơ Thành viên</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav navbar-right">
          	<li  class="active"><a href=".">Hồ sơ</a></li>
            <li><a href=".">Cài đặt</a>
				
            </li>
          </ul>

        
        </div>
      </div>
    </nav>

	 <div class="container-fluid">
      <div class="row">
        <div style="background: #00a82d;" class="col-xs-12 col-md-2 pull-right sidebar">
          <ul class="nav nav-sidebar">
            <li class="active"><a href="#"><span class="sr-only">(Hiện hành)</span></a></li><!-- lỗi mới hiển thị -->
            <legend>Quản lí Giao Dịch</legend>
            <li><a href="#">Đơn hàng</a></li>
            <li><a href="#">Địa chỉ nhân hàng</a></li>
            <li><a href="#">Sản phẩm yêu thích</a></li>
          </ul>
          <br>
          <ul class="nav nav-sidebar">
           <legend>Quản lí Tài Khoản</legend>
            <li><a href="">Thông tin tài khoản</a></li>
       		<li><a href="">Hộp thư</a></li>
       		<li><a href="">Mã Giảm giá</a></li>
       		<li><a href="">Hỗ trợ</a></li>
          </ul>
          <br>
          
        </div><!-- end left -->
		
		 <div class="col-xs-12 col-sm-10 col-md-10 main">
          <h3 class="page-header">Hồ sơ</h3>
          <div class="col-md-3">
          		<img src="./View/assets/images/anh_dai_dien.jpg" alt="..." class="img-circle">
          </div>
          <div class="col-md-7">
          	<dl class="dl-horizontal">
<?php 
      


     
            
?> 
 					  <dt>FirstName:</dt>			 
 				     	<dd>
                <?php echo $user_info[$i]->first_name; ?>
              </dd>

 					  <dt>LastName</dt>
 					  <dd> 
              <?php echo $user_info[$i]->last_name; ?>
 					  </dd>
 					   <dt>Email</dt>
 					  <dd> 
              <?php $user_info[$i]->email; ?>
 					  </dd>
 					  <dt>Password</dt>
 					  <dd>
 					  		<?php
                      echo '******';
                 ?>
						</dd>
						<dt>Mobile</dt>
 					  <dd>
 					  		<?php echo $user_info[$i]->mobile; ?>
						</dd>
            <dt>Address #1</dt>
            <dd>
                <?php echo $user_info[$i]->address1; ?>
            </dd>
            <dt>Address #2</dt>
            <dd>
                <?php echo $user_info[$i]->address2; ?>
            </dd>
          <button type="button" class="pull-right btn btn-success">
            <form action="." method="POST">
              <input type="hidden" value="update_user_view" name="action">
              <input type="hidden" value="<?php echo $user_info[$i]->email; ?>" name="g_email">
              <input style="background:none; border:none;" type="submit" value="Edit">
            </form>
           </button>
           <?php } ?>
					</dl>
          </div>
		
        </div><!-- end right -->
		
	  </div><!-- end row -->

	</div>  

<?php 

        }
    }
  
 ?>
