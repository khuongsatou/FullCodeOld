<?php 
	setcookie('user','khương',time()+3600);
	// echo time()+3600;
	echo $_COOKIE['user'];
	setcookie('user','khương',time()-3600);


 ?>