<?php 
	if (!is_admin()) {
		redirect(base_url('admin'),array('m'=>'common','a'=>'logout'));
	}
 ?>
 <?php 
 	include_once 'widgets/header.php';
  ?>
<?php //phân trang
	$sql = db_create_sql('SELECT COUNT(id) as counter FROM tb_user {where}');
	$result = db_get_row($sql);
	$total_records = $result['counter'];
    //Lấy trang hiện tại
    $current_page = input_get('page');

    $limit =10;
    $link = create_link(base_url('admin'),array(
        'm'=>'user',
        'a'=>'list',
        'page' => '{page}'
    ));

    $paging = paging($link,$total_records,$current_page,$limit);
    $sql = db_create_sql("SELECT * FROM tb_user {where} LIMIT {$paging['start']},{$paging['limit']}");
    $users = db_get_list($sql);
 ?>

<h1>Danh sách thành viên</h1>
<div class="controls">
    <a class="button" href="<?php echo create_link(base_url('admin'), array('m' => 'user', 'a' => 'add')); ?>">Thêm</a>
</div>
<table cellspacing="0" cellpadding="0" class="form">
    <thead>

        <tr>
        
            <td>Username</td>
            <td>Email</td>
            <?php if (is_supper_admin()){ ?>
            <td>Action</td>
            <?php } ?>
        </tr>
    </thead>
    <tbody>
        <?php // VỊ TRÍ 02: CODE HIỂN THỊ NGƯỜI DÙNG 
            foreach ($users as $item) {
        ?>
        
    <tr>
    <td><?php echo $item['username']; ?></td>
    <td><?php echo $item['email']; ?></td>
    <td>
        <form method="POST" class="form-delete" action="<?php echo create_link(base_url('admin/index.php'), array('m' => 'user', 'a' => 'delete')); ?>">
            <a href="<?php echo create_link(base_url('admin'), array('m' => 'user', 'a' => 'edit', 'id' => $item['id'])); ?>">Edit</a>
            <input type="hidden" name="user_id" value="<?php echo $item['id']; ?>"/>
            <input type="hidden" name="request_name" value="delete_user"/>
            <a href="#" class="btn-submit">Delete</a>
        </form>
    </td>
</tr>


        <?php } ?>
    </tbody>
</table>
 
<div class="pagination">
    <?php // VỊ TRÍ 03: CODE HIỂN THỊ CÁC NÚT PHÂN TRANG 
    echo $paging['html'];
    ?>
</div>
 
<?php include_once('widgets/footer.php'); ?>

