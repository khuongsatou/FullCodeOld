<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<script type="text/javascript" src="../jquery-3.1.0.min.js"></script>
<script>
$(document).ready(function(){
	$("#tinh").click(function(){
		var txta = $("#txtA").val();
		var txtb = $("#txtB").val();
		$.post("xuly.php", {a:txta , b:txtb }, function(data){
			$("#ketqua").html(data);
		});
	});
});
</script>
</head>

<body>


	<input id="txtA" name="txtA" type="text" /><br/>
    <input id="txtB" name="txtB" type="text" />
    <input id="tinh" type="button" value="Gui">
	<h2 id="ketqua"></h2>

<iframe scrolling="no" width="560" height="355" src="http://mp3.zing.vn/embed/video/ZW7UCCFF?start=true" frameborder="0" allowfullscreen="true"></iframe>

</body>
</html>
