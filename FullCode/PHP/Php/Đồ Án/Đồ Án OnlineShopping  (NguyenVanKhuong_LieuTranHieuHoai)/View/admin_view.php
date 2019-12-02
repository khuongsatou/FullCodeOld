
<?php 
		if (isset($_POST['user_id']) && isset($_POST['action'])) {
			$user_info_m ->Delete_user_id($_POST['user_id']);
			


		}
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

          <a class="navbar-brand" href=".">Trang Admin</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav navbar-right">
            <li class="active"><a href="#">Bảng điều kiển</a></li>
            <li><a href="#">Cài đặt</a></li>
            <li><a href="#">Hồ sơ</a></li>
            <li><a href="#">Help</a></li>
          </ul>
			
		
		 
          <form method="POST" action="." class="navbar-form navbar-right">
          	<input type="hidden" value="admin_view" name="action">
            <input name="search" type="text" class="form-control" placeholder="Search...">
            <input name="search_submit" class="btn btn-primary" type="submit" value="Tìm" class="form-control">
          </form>

	
		


        </div>
      </div>
    </nav>

	 <div class="container-fluid">
      <div class="row">
        <div style="background: #00a82d;" class="col-xs-12 col-md-2 sidebar">
          <ul class="nav nav-sidebar">
            <li class="active"><a href="#"><span class="sr-only">(Hiện hành)</span></a></li><!-- lỗi mới hiển thị -->
            <li><a href="#">Báo cáo</a></li>
            <li><a href="#">Lưu lượng truy cập</a></li>
          </ul>
          
          <ul class="nav nav-sidebar">
           <li class="dropdown">
						<a href="#" class="dropdown-toggle" data-toggle="dropdown">Quản lí nhân viên</a>
						<ul style="background:red;" class="dropdown-menu">
							<li><a href="">Thêm nhân viên</a></li>
							<li><a href="">Xóa nhân viên</a></li>
							<li><a href="">Sửa nhân viên</a></li>
						</ul>
					</li>
            <li><a href="#">Quản lí user</a></li>
       		 <li class="dropdown">
						<a href="#" class="dropdown-toggle" data-toggle="dropdown">Quản lí bài viết</a>
						<ul style="background:red;" class="dropdown-menu">
							<li><a href="">Thêm bài viết</a></li>
							<li><a href="">Xóa bài viết</a></li>
							<li><a href="">Sửa bài viết</a></li>
						</ul>
					</li>
          </ul>
          
          <ul class="nav nav-sidebar">
            <li><a href="">Quản kho</a></li>
            <li class="dropdown">
						<a href="#" class="dropdown-toggle" data-toggle="dropdown">Quản lí sản phẩm</a>
						<ul style="background:red;" class="dropdown-menu">
							<li><a href="">Thêm Sản Phẩm</a></li>
							<li><a href="">Xóa Sản Phẩm</a></li>
							<li><a href="">Sửa Sản Phẩm</a></li>
						</ul>
					</li>
          </ul>
        </div><!-- end left -->
		
		 <div class="col-xs-12 col-sm-10 col-md-10 main">
          <h3 class="page-header">ReView All Use</h3>
		<table class="table table table-bordered">
			<thead>
				<tr>
					<th>user_id</th>
					<th>first_name</th>
					<th>last_name</th>
					<th>email</th>
					<th>password</th>
					<th>address1</th>
					<th>address2</th>
					<th>action</th>
				</tr>
			</thead>
			<tbody>
<?php 
		if (isset($_POST['search_submit'])) {
			 $user_info = $user_info_m ->Select_user_info_search($_POST['search']);
		}
		for ($i = 0; $i <count($user_info) ; $i++) {
		    echo '<tr>';
		    echo '<td>';
		    	echo $user_info[$i]->user_id;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->first_name;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->last_name;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->email;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->password;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->address1;
		    echo '</td>';
		    echo '<td>';
		    	echo $user_info[$i]->address2;
		    echo '</td>';
		    echo '<td>';
		    	echo '<form action="." method="POST">';
		    	echo '<input type="hidden" value="admin_view" name="action">';
		    	echo '<input type="hidden" value="'.$user_info[$i]->user_id.'" name="user_id">';
		    	echo '<button class="btn btn-default">Xóa</button>';
		    	echo '</form>';
		    echo '</td>';
		    echo '</tr>';
		}
?>				
		

			</tbody>
		</table>
		<div class="row">
		<!-- <div class="btn-group col-md-offset-4" role="group" aria-label="...">
 			 	<button type="button" class="btn btn-default">1</button>
 				<button type="button" class="btn btn-default">2</button>
  				<button type="button" class="btn btn-default">3</button>
  				<button type="button" class="btn btn-default">4</button>
 				<button type="button" class="btn btn-default">5</button>
  				<button type="button" class="btn btn-default">6</button>

  				<button style="background-color: green;color:white" class="btn btn-default">về trang chủ</button>
		</div> --><!-- end btn -->
		</div><!-- end row -->
        </div><!-- end right -->
		
	  </div><!-- end row -->

	</div>  