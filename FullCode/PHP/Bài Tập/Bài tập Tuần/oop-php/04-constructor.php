<?php
 
class MyClass
{
  public $prop1 = "I'm a class property!";
 
  public function __construct()
  {
      echo 'The class "', __CLASS__, '" was initiated!<br />';
  }
}
 
// Create a new object
$obj = new MyClass;
 
// Output a message at the end of the file
echo "End of file.<br />";
 
?>