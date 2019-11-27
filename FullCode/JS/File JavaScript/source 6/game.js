//Lấy thông tin
var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung



//Khởi tạo giá trị biến
var x=20,y=20;//khởi tạo tọa độ bóng
var dx=4,dy=4;//Gia tốc
var radius=20;
var thanh={
	width:150,
	height:50,
	x:0,
	y:canvas.height-50,
	speed:10,
	isMoveLeft:false,
	isMoveRight:false
};//mảng đối tượng thanh
var gameOver=false;

//tạo thanh trắng
function thanhchan() {
	ctx.beginPath();
	ctx.rect(thanh.x, thanh.y, thanh.width, thanh.height);
	ctx.fillStyle="Green";
	ctx.fill();
	ctx.closePath();
}

//nhấn vào
document.addEventListener('keydown', function(event) {//bắt sự kiện -> xuống
	// console.log("keydown");
	// console.log(event);


	if (event.keyCode == 37) {//trái
		thanh.isMoveLeft=true;
	}else if (event.keyCode == 39 ) {//phải
		thanh.isMoveRight=true;
	}

	// if (event.keyCode == 37) {//trái
	// 	thanh.x -= thanh.speed;
	// }
	// else if (event.keyCode == 39 ) {//phải
	// 	thanh.x += thanh.speed;
	// }
});

//thả ra
document.addEventListener('keyup', function(event) {
	if (event.keyCode==37) {
		thanh.isMoveLeft=false;
	}else if (event.keyCode == 39) {
		thanh.isMoveRight=false;
	}
});

//Các hàm Ball
function Ball() {
	ctx.beginPath();//reset
	ctx.arc(x, y, radius, 0, Math.PI*2, true);//tọa hình tròn
	ctx.fillStyle="red"//màu cho hình
	ctx.fill();//full màu đen
	ctx.stroke();//viền
	ctx.closePath();
}

//xử lí va chạm ball
function vaChamBallCanvas() {
	if ( x < radius || x > canvas.width-radius) {//-x -> x , cho nó chạm vào bán kính
		dx=-dx;//có nghĩa là nó sẽ tăng tọa độ lên
	}
	if ( y < radius || y > canvas.height-radius) {
		dy=-dy;
	}
}

function updatePosition() {
	x+=dx;//cập nhật lại tọa độ
	y+=dy;
}

//xử lí ball va chạm với thanh
function vaChamThanh() {
	if (x + radius >= thanh.x && x + radius <= thanh.x + thanh.width &&
	y+radius >= canvas.height-thanh.height) {//x>x.thanh , x<x.thanh,y>canvas.height
		dy=-dy;
	}
}
//xử lí thanh chạm trường
function ThanhChamCavans() {
	if (thanh.isMoveLeft) {
			thanh.x -= thanh.speed;
		}else if (thanh.isMoveRight) {
			thanh.x += thanh.speed;
		}

		//xử lí thành canvas
		if (0 > thanh.x) {
			thanh.x = 0;
		}else if (thanh.x>canvas.width-thanh.width) {
			thanh.x=canvas.width-thanh.width;
		}
}


//tạo gạch

function drawAnimation() {
	if (!gameOver) {
		ctx.clearRect(0, 0, canvas.width,canvas.height);//xóa toàn bộ khung canvas đi , nói chung là lệnh xóa màng hình
		Ball();//gọi hàm tạo
		thanhchan();
		//xử lí chạm biên
		ThanhChamCavans()//thanh va chạm với tường
		vaChamBallCanvas()//va cham vao thanh
		vaChamThanh();
		updatePosition();//+-+-
		
		//xử lí game over
		if (y > canvas.height-radius) {
			gameOver=true;
		}

		requestAnimationFrame(drawAnimation);//đệ quy để tạo độ mượt
	}else{
		console.log("GameOver");
	}
	
}

drawAnimation();//gọi ít nhất 1 lần


//Bắt sự kiện

// document.addEventListener('keypress', function(event) {//sự kiện key
// 	console.log(event);
// });

// document.addEventListener('keyup', function(event) {//xuống 
// 	console.log("keyup");
// 	console.log(event);
// });

