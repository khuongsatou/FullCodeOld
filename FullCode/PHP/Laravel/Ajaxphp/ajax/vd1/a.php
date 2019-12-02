<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<script type="text/javascript" src="../jquery-3.1.0.min.js"></script>
<script>
$(document).ready(function(){
	
	$.get("hello.php", function(data){
		$("#noidung2").html(data);
	});
	
	//     b.php?ho=TEONGUYEN
	$.post("b.php", {ho:"TEONGUYEN"}, function(data){
		$("#noidung").html(data);
	});
});
</script>
</head>

<body>
<p>AAAA</p>
<div id="noidung">...</div>
<div id="noidung2">...</div>
</body>
</html>