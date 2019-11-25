<?php 
	include 'header.php';
	include 'database.php';
 ?>		

 	<form action="TimKiem.php" method="POST" role="form">
		
		<div class="form-group">
			<label for="">Nhập Tên Sản Phẩm</label>
			<input name="tensp" type="text" class="form-control" id="" placeholder="">
			
		</div>
	
		<button name="OK" type="submit" class="btn btn-primary">Tìm</button>
	</form>

 	<table class="table table-hover">
		<thead>
			<tr>
				<th>Mã Sản Phẩm</th>
				<th>Tên Sản phẩm</th>
				<th>Giá</th>
			</tr>
		</thead>
		<tbody>
			<?php
				if (isset($_POST['OK'])) {
					$tensp = isset($_POST['tensp']) ? $_POST['tensp'] : "";
					if (empty($tensp)) {
						echo 'Không Có sản phẩm';
					}else{
						$result = select_sanpham_tensp($tensp);
	 			  		while ($row = mysqli_fetch_array($result)) { 
					
					
				
				
	 		?>
				<tr>
					<td><?php echo $row['MaSP']; ?></td>
					<td><?php echo $row['TenSp']; ?></td>
					<td><?php echo $row['Gia']; ?></td>
				</tr>
			<?php 		}
					}
				}
			 ?>
		</tbody>
	</table>




 <?php 
 	include 'footer.php';
 ?>