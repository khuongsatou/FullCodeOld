<?php 
	include 'header.php';
	include 'database.php';
 ?>

	<?php 
		if (isset($_POST['OK'])) {
			$tensp = isset($_POST['tensp']) ? $_POST['tensp'] : "";
			$gia 	= isset($_POST['gia']) ? $_POST['gia'] : "";
			if (empty($tensp) && empty($gia)) {
				echo "Phải nhập đầy đủ";
			}else{
				insert_sanpham($tensp,$gia);
				echo 'Thêm Thành Công';
			}

		}


	 ?>


	<form action="Them.php" method="POST" role="form">
		
		<div class="form-group">
			<label for="">Tên Sản Phẩm</label>
			<input name="tensp" type="text" class="form-control" id="" placeholder="">
			<label for="">Giá</label>
			<input name="gia" type="text" class="form-control" id="" placeholder="">
		</div>
	
		<button name="OK" type="submit" class="btn btn-primary">OK</button>
	</form>

 <?php 
 	include 'footer.php';
 ?>