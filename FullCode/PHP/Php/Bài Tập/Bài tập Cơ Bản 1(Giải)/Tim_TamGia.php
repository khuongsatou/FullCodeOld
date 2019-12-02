<?php 
	include 'header.php';
	include 'database.php';
 ?>		

 	<form action="Tim_TamGia.php" method="POST" role="form">
		
		<div class="form-group">
			<label for="">Nhập Giá Sản Phẩm</label>
			<input name="x" type="text" class="form-control" id="" placeholder="x">
			<input name="y" type="text" class="form-control" id="" placeholder="y">
			
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
					$x = isset($_POST['x']) ? $_POST['x'] : "";
					$y = isset($_POST['y']) ? $_POST['y'] : "";
					if (empty($x) || empty($y)) {
						echo 'Không Có sản phẩm';
					}else{
						$result = select_sanpham_gia($x,$y);
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