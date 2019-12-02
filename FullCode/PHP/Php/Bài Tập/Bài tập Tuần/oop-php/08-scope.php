<?php
 
 class MyClass
 {
   public $prop1 = "I'm a class property!";
  
   private function getProperty()
   {
       return $this->prop1 . "<br />";
   }
 }
  
 class MyOtherClass extends MyClass
 {
   public function __construct()
   {
       parent::__construct();
       echo "A new constructor in " . __CLASS__ . ".<br />";
   }
  
   public function newMethod()
   {
       echo "From a new method in " . __CLASS__ . ".<br />";
   }
  
   public function call()
   {
       return $this->getProperty();
   }
 }
  
 // Create a new object
 $newobj = new MyOtherClass;
  
 // Use a method from the parent class
 echo $newobj->call();
  
 ?>