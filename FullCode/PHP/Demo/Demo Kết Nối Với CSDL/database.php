<?php 
	class DataBase{
		private $Host;
		private $User;
		private $Password;
		private $DatabaseName;
		private $conn;

		public function __construct()
		{
			$this->Host = "localhost";
			$this->User = "root";
			$this->Password = "";
			$this->DatabaseName = "";
		}


		public function connect()
		{
			$this->conn = mysqli_connect($this->Host,$this->User,$this->Password,$this->DatabaseName) or die("Kết nối thất bại");
			mysqli_set_charset($this->conn,"utf8");

		}
		public function query($sql)
		{
			return mysqli_query($this->conn,$sql);
		}

	}

 ?>