<?php 
	class DataBase{
		protected $conn;
		public function getConnect()
		{
			echo $this->conn;
			if (!$this->conn) {
				$this->conn = mysqli_connect("localhost","root","","onlineshopping") or die("Kết nối thất bại");
				mysqli_set_charset($this->conn,'utf8');
			}
		}
		public function getDisconnect()
		{
			if ($this->conn) {
				mysqli_close($this->conn);
			}
		}
	}

 ?>