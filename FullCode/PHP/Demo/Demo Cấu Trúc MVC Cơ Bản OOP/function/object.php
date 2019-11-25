<?php 
class Product {
    public $id;
    public $title;
    public $price;
    public $image;
    public function __construct($id, $title, $price, $image) {
        $this->id = $id;
        $this->title = $title;
        $this->price = $price;
        $this->image = $image;
    }
}
?>