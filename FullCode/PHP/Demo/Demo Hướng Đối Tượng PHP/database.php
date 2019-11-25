<?php 
class Database
{
	public $host;
	public $user;
	public $pass;
	public $database;
	public $con;
	public $result;

public function connect(){
	$this->con =mysqli_connect($this->host,$this->user,$this->pass);
	mysqli_select_db($this->con,$this->database);
}
public function __construct($host,$user,$pass,$database)
{
	$this->database=$database;
	$this->user=$user;
	$this->pass=$pass;
	$this->host=$host;
}
public function query($query_clause) {
	$this->result = mysqli_query($this->con, $query_clause);
}

}
?>