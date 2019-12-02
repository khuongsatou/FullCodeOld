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
            $conn   = mysqli_connect("localhost","root","","paging_example");
            //tìm tổng số records
            $result = mysqli_query($conn,"SELECT count(id) as total FROM `news` ");
            $row    = mysqli_fetch_assoc($result); 
            $total_records= $row['total'];
            $curent_page = isset($_GET['page']) ? $_GET['page'] : 1;
            $limit = 10;

            //tính toán total_page và start
            $total_page = ceil($total_records / $limit);
            if ($curent_page > $total_page) {
                $curent_page = $total_page;
            }else if($curent_page < 0){
                $curent_page = 1;
            }

            $start = ($curent_page -1 ) * $limit;
            $result = mysqli_query($conn,"SELECT * FROM `news` LIMIT $start,$limit");
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
                if ($curent_page > 1 && $total_page > 1) {
                    echo ' <a href="?page='.($curent_page - 1).'">prev</a>';
                }

                for ($i = 1; $i <= $total_page; $i++) {
                    if ($curent_page == $i) {
                        echo '<span>'.$i.'</span> |';
                    }else{
                        echo '<a href="?page='.$i.'"> '.$i.' </a> | ';
                    }
                }

                 if ($curent_page < $total_page && $total_page > 1) {
                    echo ' <a href="?page='.($curent_page + 1).'">next</a>';
                }

           ?>
        </div>
    </body>
</html>