<?php 
	class ob_Product{
		public $id;
        public $cat;
        public $brand;
        public $title;
        public $price;
        public $desc;
        public $image;
        public $keywords;
        public function __construct($id,$cat,$brand,$title,$price,$desc,$image,$keywords)
        {
            $this->id=$id;
            $this->cat=$cat;
            $this->brand=$brand;
            $this->title=$title;
            $this->price=$price;
            $this->desc=$desc;
            $this->image=$image;
            $this->keywords=$keywords;
        }


	}


 ?>