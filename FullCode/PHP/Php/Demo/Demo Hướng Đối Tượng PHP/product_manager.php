<?php
include "product.php";
class ProductManager {
	public $productList = array();
	public $quantity;

	public function loadProduct($db) {
		$db->query("SELECT * FROM sanpham");
		while ($row = mysqli_fetch_array($db->result)) {

			$product = new Product($row['masp'], $row['tensp'], $row['gia']);
			echo var_dump($product->price) . "<br>";
			$this->productList[$product->id] = $product;
		}
	}
	public function __toString() {
		return $this->productList['01']->name;
	}
}
?>