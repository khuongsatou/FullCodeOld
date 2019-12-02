<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<script type="text/javascript" src="../jquery-3.1.0.min.js"></script>
<script>
$(document).ready(function(){
	$("#txtUsername").blur(function(){
		var u = $(this).val();
		$.get("checkUsername.php", {un:u}, function(data){
			if( data==0 ){
				$("#nhacLoiUn").html("Hợp lệ");
				$("#nhacLoiUn").css("color", "blue");
			}else{
				$("#nhacLoiUn").html("Không hợp lệ");
				$("#nhacLoiUn").css("color", "red");
			}
		});	
	});	
});
</script>
</head>

<body>
<form action="" method="post">
<table width="400" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2">DANG KY THANH VIEN</td>
    </tr>
  <tr>
    <td>Username</td>
    <td><label for="txtUsername"></label>
      <input type="text" name="txtUsername" id="txtUsername" />
      <div id="nhacLoiUn"></div>
      </td>
  </tr>
  <tr>
    <td>Password</td>
    <td><label for="txtPassword"></label>
      <input type="password" name="txtPassword" id="txtPassword" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td><input type="submit" name="btnDangKy" id="btnDangKy" value="Dang ky" /></td>
  </tr>
</table>
</form>
</body>
</html>