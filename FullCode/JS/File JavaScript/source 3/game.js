var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung

var x=20,y=20;

function Ball() {
	ctx.beginPath();
	ctx.arc(x, y, 20, 0, Math.PI*2, true);
	ctx.fillStyle="aqua"
	ctx.fill();
	ctx.stroke();
}


// setInterval(function () {
// 	ctx.clearRect(0, 0, canvas.width,canvas.height);//xóa toàn bộ khung canvas đi
// 	Ball();
// 	x+=10;
// 	y+=10;
// }, 10)

function drawAnimation() {
	ctx.clearRect(0, 0, canvas.width,canvas.height);//xóa toàn bộ khung canvas đi , nói chung là lệnh xóa màng hình
	Ball();//gọi hàm tạo
	x+=2;
	y+=2;
	requestAnimationFrame(drawAnimation);//đệ quy để tạo độ mượt
}

drawAnimation();//gọi ít nhất 1 lần