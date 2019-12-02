<?php 
	class DB_shopping
	{
		//biến lưu trữ kết nối
		private $__conn;
		//Hàm kết nối
		function connect(){
			//nếu chưa kết nối thì thực hiện kết nối
			if(!$this->conn){
				//kết nối
				$this->_conn=new mysqli("localhost","root","","onlineshopping") or die ('Lỗi kết nối');
				//xử lý truy vấn utf8 để tránh lỗi font
				// mysqli_query($this->_con,"SET character_set_results='utf8',character_set_client='utf8', character_set_database = 'utf8', character_set_server = 'utf8'");
			}
		}
		//Hàm ngắt kết nối
		function dis_connect(){
			//nếu đang kết nối thì ngắt kết nối
			if($this->_conn){
				mysqli_close($this->_conn);
			}
		}
		//Hàm lấy danh sách
		function get_list($sql){
			//kết nối
			$this->connect();
			$result=mysqli_query($this->_conn,$sql);
			if(!$result){
				die('câu truy vấn có vấn đề');
			}
			$return =array();
			//lặp qua kết quả để đưa vào mảng
			while($row=mysqli_fetch_assoc($result)){
				$return[]=$row;
			}
			// xóa kết quả khỏi bộ nhớ
			mysqli_free_result($result);
			return $return;
		}
	}
 ?>