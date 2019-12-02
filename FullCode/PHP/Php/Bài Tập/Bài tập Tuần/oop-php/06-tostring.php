<?php
 
class MyClass
{
  public $prop1 = "I'm a class property!";
 
  public function __construct()
  {
      echo 'The class "', __CLASS__, '" was initiated!<br />';
  }
 
  public function __destruct()
  {
      echo 'The class "', __CLASS__, '" was destroyed.<br />';
  }
 
  public function __toString()
  {
      echo "Using the toString method: ";
      return $this->prop1;
  }
}
 
// Create a new object
$obj = new MyClass;
 
// Output the object as a string
echo $obj;
 
// Output a message at the end of the file
echo "End of file.<br />";
 
?>