<!DOCTYPE html>
<html>
    <head>
        <title>Ví dụ phân trang trong PHP và MySQL</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
    </head>
    <body>
        <?php 
        // PHẦN XỬ LÝ PHP
        $conn = mysqli_connect("localhost","root","","paging_example");
        $result = mysqli_query($conn,"SELECT count(*) as 'total' FROM news");
        $row = mysqli_fetch_assoc($result);
        $total_records = $row['total'];
        //tìm page hiện tại
        $current_page = isset($_GET['page']) ? $_GET['page'] : 1 ;
        $limit = 5;

        $total_page = ceil($total_records / $limit);

        if ($current_page < 1) {
        	$current_page = 1;
        }else if ($current_page > $total_page) {
        	$current_page = $total_page;
        }


       	//tính số page bắt đầu
       	$start = ($current_page - 1)* $limit;

       	//thực hiện select ra
       	$result = mysqli_query($conn,"SELECT * FROM news LIMIT $start,$limit");
        ?>
        <div>
            <?php 
            // PHẦN HIỂN THỊ TIN TỨC
            while ($row = mysqli_fetch_assoc($result)) {
                echo $row['title'].'<br>';
            }



            ?>
        </div>
        <div class="pagination">
		
           <?php 
            // PHẦN HIỂN THỊ PHÂN TRANG
           	if ($current_page > 1 && $total_page > 1) {
           		echo '<a href="?page='.($current_page - 1).'"> prev </a>';
           	}else{
           		echo '<span> prev </span>';
           	}
         	for ($i = 1; $i <=  $total_page; $i++) {
         		if ($current_page == $i) {
         			echo '<span>'.$i.'</span>';
         		}else{
         			echo '<a href="?page='.$i.'"> '.$i.' </a>';
         		}
         	}

         	if ($current_page < $total_page && $total_page > 1) {
           		echo '<a href="?page='.($current_page + 1).'"> next </a>';
           	}else{
           		echo '<span> next </span>';
           	}

           ?>
        </div>
    </body>
</html>