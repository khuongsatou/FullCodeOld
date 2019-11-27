var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung

//x,y->+x
//|
//+y
ctx.beginPath();//bắt đầu vễ 1 đường mới
ctx.moveTo(50,5);//di chuyển
ctx.lineTo(300, 150);
ctx.lineTo(0, 150);
ctx.lineTo(0, 0);//di chuyển tới
ctx.stroke();//thực hiện vẽ màu den mặc định
