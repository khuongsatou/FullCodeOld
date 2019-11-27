var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung

var x=20,y=20;//khởi tạo tọa độ bóng
var dx=4,dy=4;//Gia tốc
var radius=20;
function Ball() {
	ctx.beginPath();//reset
	ctx.arc(x, y, radius, 0, Math.PI*2, true);//tọa hình tròn
	ctx.fillStyle="aqua"//màu cho hình
	ctx.fill();//full màu đen
	ctx.stroke();//viền
}


function vaChamBallCanvas() {
	if ( x < radius || x > canvas.width-radius) {//-x -> x , cho nó chạm vào bán kính
		dx=-dx;//nếu x đang âm thì  cho nó thành dương
	}
	if ( y < radius || y > canvas.height-radius) {
		dy=-dy;
	}
}

function updatePosition() {
	x+=dx;
	y+=dy;
}


function drawAnimation() {
	ctx.clearRect(0, 0, canvas.width,canvas.height);//xóa toàn bộ khung canvas đi , nói chung là lệnh xóa màng hình
	Ball();//gọi hàm tạo
	vaChamBallCanvas()//va cham vao thanh
	updatePosition();//+-+-
	requestAnimationFrame(drawAnimation);//đệ quy để tạo độ mượt
}

drawAnimation();//gọi ít nhất 1 lần


//Bắt sự kiện

// document.addEventListener('keypress', function(event) {//sự kiện key
// 	console.log(event);
// });

document.addEventListener('keyup', function(event) {
	console.log("keyup");
	console.log(event);
});

document.addEventListener('keydown', function(event) {
	console.log("keydown");
	console.log(event);
});