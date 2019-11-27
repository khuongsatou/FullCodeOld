var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung

//x,y->+x
//|
//+y
//vẽ hình chữ nhật
ctx.beginPath();//bắt đầu 
ctx.rect(0, 0, 50, 50);
ctx.strokeStyle="#ff0";//tô màu viền
ctx.stroke();//tô màu mặc định vẽ


ctx.beginPath();//reset 
ctx.rect(0, 100, 100, 50);//x,y ,w,h
ctx.stroke();
ctx.fillStyle = "#ff0";//tô màu 
ctx.fill();