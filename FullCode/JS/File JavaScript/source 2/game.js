var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung

ctx.beginPath();
ctx.arc(50, 50, 10, 0, Math.PI*1.2 , true);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.arc(50, 50, 10, 0, Math.PI*2 , true);
ctx.stroke();


ctx.beginPath();
ctx.arc(150, 150, 60, 0, Math.PI*2 , true);//x,y,bán kính, bắt đầu 3h, Kết thúc 1Pi 9h ,True ngược kim đồng hồ
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.arc(150, 150, 135, 0, Math.PI*2 , true);//x,y,bán kính, bắt đầu 3h, Kết thúc 1Pi 9h ,True ngược kim đồng hồ

ctx.stroke();