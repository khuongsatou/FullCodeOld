//Lấy thông tin
var canvas=document.getElementById('game');//lấy thẻ
var ctx = canvas.getContext("2d");//gán nội dung



//Khởi tạo giá trị biến
var ball={
	x:20,
	y:20,
	dx:5,
	dy:3,
	radius:10
};

var thanh={
	width:130,
	height:20,
	x:0,
	y:canvas.height-20,
	speed:20,
	isMoveLeft:false,
	isMoveRight:false
};

var gach={
	offsetX:25,
	offsetY:25,
	width:70,
	height:15,
	margin:25,
	row:3,
	col:5
};

var doituongGach=[];

var userSum=0;
var win=gach.row*gach.col;
var ThangGame=false;
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
document.addEventListener('keydown', function(event) {
	if (event.keyCode == 37) {
		thanh.isMoveLeft=true;
	}else if (event.keyCode == 39 ) {
		thanh.isMoveRight=true;
	}
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
	ctx.arc(ball.x, ball.y, ball.radius, 0, Math.PI*2, true);//tọa hình tròn
	ctx.fillStyle="red"//màu cho hình
	ctx.fill();//full màu đen
	ctx.stroke();//viền
	ctx.closePath();
}

//xử lí va chạm ball
function vaChamBallCanvas() {
	if ( ball.x < ball.radius || ball.x > canvas.width-ball.radius) {//-x -> x , cho nó chạm vào bán kính
		ball.dx=-ball.dx;//có nghĩa là nó sẽ tăng tọa độ lên
	}
	if ( ball.y < ball.radius || ball.y > canvas.height-ball.radius) {
		ball.dy=-ball.dy;
	}
}

function updatePosition() {
	ball.x+=ball.dx;//cập nhật lại tọa độ
	ball.y+=ball.dy;
}

//xử lí ball va chạm với thanh
function vaChamThanh() {
	if (ball.x + ball.radius >= thanh.x && 
		ball.x + ball.radius <= thanh.x + thanh.width &&
		ball.y + ball.radius >= canvas.height-thanh.height) {//x>x.thanh , x<x.thanh,y>canvas.height
		ball.dy=-ball.dy;
		
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
		}else if (thanh.x > canvas.width-thanh.width) {
			thanh.x=canvas.width-thanh.width;
		}
}

//Thêm gạch vào mảng
function ThemGach() {
	for (var i = 0; i < gach.row; i++) {//3 row
		for (var j = 0; j < gach.col; j++) {//5 col
			doituongGach.push({
				x: gach.offsetX+j*(gach.width+gach.margin),
				y: gach.offsetY+i*(gach.height+gach.margin),
				isbroken:false
			});
		}
	}
}
ThemGach();

//tạo gạch
function createGach() {
		doituongGach.forEach(function(b) {
			if (!b.isbroken) {
			ctx.beginPath();
			ctx.rect(b.x,b.y,gach.width,gach.height);
			ctx.fill();
			ctx.closePath();
			}
	});
	
}

//va chạm với gạch
function vachamGach() {
	doituongGach.forEach(function(b){
		if (!b.isbroken) {
			if (ball.x >=b.x && ball.x <= b.x + gach.width &&
				ball.y + ball.radius >= b.y && ball.y - ball.radius <= b.y + gach.height
				) {
				ball.dy =-ball.dy;
				b.isbroken = true;
				userSum++;
				if (userSum >= win) {
					ThangGame=true;
				}
		}
		}
	});
}


//main
function drawAnimation() {
	if (!ThangGame) {
		if (!gameOver) {
			ctx.clearRect(0, 0, canvas.width,canvas.height);//xóa toàn bộ khung canvas đi , nói chung là lệnh xóa màng hình
			
			Ball();//gọi hàm tạo
			thanhchan();
			//xử lí chạm biên
			ThanhChamCavans()//thanh va chạm với tường
			vaChamBallCanvas()//va cham vao thanh
			vaChamThanh();//ball với thanh
			updatePosition();//+-+-
			
			//gạch
			 createGach();
			//xử lí game over
			vachamGach();
			if (ball.y > canvas.height-ball.radius) {
				gameOver=true;
			}

			requestAnimationFrame(drawAnimation);//đệ quy để tạo độ mượt
		}else{
			alert('GameOver');
		}
	}else {
		alert("Win");
	}
}

drawAnimation();//gọi ít nhất 1 lần


