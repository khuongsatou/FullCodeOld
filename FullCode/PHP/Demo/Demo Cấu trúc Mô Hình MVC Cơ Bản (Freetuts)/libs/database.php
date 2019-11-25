<?php 
	
	$conn = null;//làm kiểu này để tránh kết nối quá nhiều

	function db_connect()
	{
		global $conn;//truy cập tới biến null bên ngoài
		if (!$conn) {// phủ định của null sẽ trả về true
			$conn = mysqli_connect('localhost','root','','php_example') or die("Không Kết nối");//trả về 1 object
			mysqli_set_charset($conn,'UTF8');
		}
	}
	function db_disconnect()
	{
		global $conn;//truy cập tới biến null bên ngoài
		if ($conn) {// phủ định của null sẽ trả về true
			mysqli_close($conn);
		}
	}

	function db_get_list($sql)
	{
		global $conn;
		db_connect();
		// echo var_dump($conn);
		$data	= array();
		$result = mysqli_query($conn,$sql);
		while ($row = mysqli_fetch_assoc($result)) {
		    $data[] =$row;
		}
		return $data;
	}
	// $data = db_get_list("SELECT* FROM `tb_user`");
	// echo var_dump($data);

	function db_get_row($sql)
	{
		global $conn;
		db_connect();
		// echo var_dump($conn);
		$row	= array();
		$result = mysqli_query($conn,$sql);
		if (mysqli_num_rows($result) >0) {//có dòng trả về true
		    $row = mysqli_fetch_assoc($result);
		}
		return $row;
	}
	// $data = db_get_row("SELECT* FROM `tb_user` where `id` = 2");
	// echo var_dump($data);
	
	function db_execute($sql)
	{
		global $conn;
		db_connect();
		return mysqli_query($conn,$sql);
	}

	function db_create_sql($sql,$filter = array())
	{
		$where = '';
		foreach ($filter as $field => $value) {
			if ($value != '') {
				$value = addslashes($value);
				$where .= "AND $field = '$value' ";
			}
		}
		$where = trim($where,'AND');

		if ($where) {
			$where = ' WHERE '.$where;
		}

		return str_replace('{where}', $where, $sql);
	}

	function db_insert($table,$data = array())
	{
		$fields = '';
		$values = '';

		foreach ($data as $field => $value) {
					$fields .= $field . ',';
					$values .= "'".addslashes($value)."',";
		}
		$fields = trim($fields, ',');
		$values = trim($values, ',');
		
		$sql = "INSERT INTO {$table}($fields) VALUES ($values)";
		return db_execute($sql);
	}
 ?>