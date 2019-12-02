<?php 
	if (isset($_POST['action']) || isset($_POST['user_id'])) {
		$user_id =	$_POST['user_id'];
		$user_select = $user_info_m ->getUserInfo_UserId($user_id);
	

 ?>

 <div class="container">
		<div class="row col-md-6 col-md-offset-2">
			<form class="form_login" action="" method="POST" role="form">
			<legend>Thông tin khách hàng</legend>
			
			<div class="form-group">
				<input type="hidden" name="action" value="pay_controller">
				<input type="hidden" name="user_id" value="<?php echo $user_id; ?>">
				<label for="">Họ & Tên</label>
				<input type="text" class="form-control" id="" placeholder="<?php echo $user_select[0]->last_name.' '.$user_select[0]->first_name; ?>" disabled="true">
				<label for="">Số điện thoại</label>
				<span style="color:red;font-size:1em;">(*)</span>
				<input type="text" class="form-control" id="" placeholder="<?php echo $user_select[0]->mobile; ?>" disabled="true">
				<label for="">Địa Chỉ Giao Hàng</label>
				<span style="color:red;font-size:1em;">(*)</span>
				<input type="text" class="form-control" id="" placeholder="<?php echo $user_select[0]->address1; ?>" >
				<label for="">Thời gian Giao Hàng</label>
				<span style="color:red;font-size:1em;">(*)</span>
				<input type="text" class="form-control" id="" placeholder=""  value="+2 Ngày" disabled="true" >

			</div>
			<button type="submit" class="btn btn-primary btn-info pull-right">Xác Nhận Thanh Toán</button>
			</form>
		</div>


	</div>
<?php } ?>