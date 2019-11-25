<?php 
	include 'header.php';
	include 'database.php';
 ?>
	<?php

	 
	     
	

	 ?>
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
				 $result = select_sanpham();
	 			  while ($row = mysqli_fetch_array($result)) { 
	 		?>
				<tr>
					<td><?php echo $row['MaSP']; ?></td>
					<td><?php echo $row['TenSp']; ?></td>
					<td><?php echo $row['Gia']; ?></td>
				</tr>
			<?php 
				}
			 ?>
		</tbody>
	</table>
<?php
  
 ?>

 <?php 


 	include 'footer.php';

  ?>