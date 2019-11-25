<!DOCTYPE html>
<html>
<head>
	<title>Thông tin tài khoản</title>
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <script src="js/jquery-1.11.1.min.js"></script>

    <style type="text/css">
		.panel-table .panel-body {  
		padding:0;
	}
	.panel-table .panel-body .table-bordered {  
	border-style: none; 
	margin:0;
	}
	.panel-table .panel-body .table-bordered > thead > tr > th:first-of-type { 
	text-align:center;  width: 100px;}.panel-table .panel-body .table-bordered > thead > tr > th:last-of-type, .panel-table .panel-body .table-bordered > tbody > tr > td:last-of-type {  
	border-right: 0px;
	}
	.panel-table .panel-body .table-bordered > thead > tr > th:first-of-type, .panel-table .panel-body .table-bordered > tbody > tr > td:first-of-type {  
	border-left: 0px;
	}
	.panel-table .panel-body .table-bordered > tbody > tr:first-of-type > td { 
	border-bottom: 0px;
	}
	.panel-table .panel-body .table-bordered > thead > tr:first-of-type > th { 
	border-top: 0px;
	}
	.panel-table .panel-footer .pagination {    
	margin:0;
	}
	.panel-table .panel-footer .col {   
	line-height: 34px;  
	height: 34px;
	}
	.panel-table .panel-heading .col h3 {   
	line-height: 30px;  
	height: 30px;
	}
	.panel-table .panel-body .table-bordered > tbody > tr > td {   
	line-height: 34px;
	}
</style>
</head>
<body>
	<nav class="navbar navbar-inverse">
		<div class="container-fluid">
			<a class="navbar-brand" href="#">Hello Admin Youkai</a>
			<ul class="nav navbar-nav">
				<li class="active">
					<a href="#">Home</a>
				</li>
				<li>
					<a href="#">Link</a>
				</li>
			</ul>
		</div>
	</nav>
	<div class="container"> 
 <div class="row"> 
  <h1 class="text-center">danh sách các tài khoản hiện có</h1> 
  <div class="col-md-18 col-md-offset-1"> 

   <div class="panel panel-default panel-table"> 
    <div class="panel-heading"> 
     <div class="row"> 
      <div class="col col-xs-4"> 
       <h3 class="panel-title">Danh sách khách hàng</h3> 
      </div> 
      <div class="col col-xs-4 text-right"> 
       <button type="button" class="btn btn-sm btn-primary btn-create">Thêm mới</button> 
      </div> 
     </div> 
    </div> 
    <div class="panel-body"> 
     <table class="table table-striped table-bordered table-list"> 
      <?php
       		$conn = new mysqli("localhost","root","","onlineshopping");
			if ($conn->connect_error) 
			{
		    	die("Kết nối thất bại: " . $conn->connect_error);
			}
					$sql="SELECT * FROM user_info";
					$result=$conn->query($sql);
				while ($row = $result->fetch_assoc()) {
				      echo "<tbody>"; 
				        echo "<tr>";
				        		echo "<td align='center'>";
				        		echo '<a href="update_controller.php?email='.$row['email'].'&user_id=';
								echo $row['user_id'];
								echo '">';
				        		echo "<i class='btn btn-default'><em class='fa fa-pencil'></em></i></a>";
				        		//------------------------------------------------------------------------
				        		echo '<a href="delete_controller.php?email='.$row['email'].'&user_id=';
								echo $row['user_id'];
								echo '">';
				        		echo "<i class='btn btn-danger'><em class='fa fa-trash'></em></i></a></td> ";
								echo "<td>".$row['user_id']."</td>";
								echo "<td>".$row['first_name']. "</td>";
								echo "<td>".$row['last_name']."</td>";
								echo "<td>".$row['email']."</td>";
								echo "<td>".$row['password']."</td>";
								echo "<td>".$row['mobile']."</td>";
								echo "<td>".$row['address1']."</td>";
								echo "<td>".$row['address2']."</td>";
							echo "</tr>";
				     echo"</tbody>";
				 }
     ?>
 	</table> 
    </div> 
    <div class="panel-footer"> 
     <div class="row"> 
      <div class="col col-xs-4">Trang 1 của 5 </div> 
      <div class="col col-xs-8"> 
       <ul class="pagination hidden-xs pull-right"> 
        <li><a href="#">1</a>
        </li> 
        <li><a href="#">2</a>
        </li> 
        <li><a href="#">3</a>
        </li> 
        <li><a href="#">4</a>
        </li> 
        <li><a href="#">5</a>
        </li> 
       </ul> 
       <ul class="pagination visible-xs pull-right"> 
        <li><a href="#">«</a>
        </li> 
        <li><a href="#">»</a>
        </li> 
       </ul> 
      </div> 
     </div> 
    </div> 
   </div> 
  </div> 
 </div>
</div>
</body>