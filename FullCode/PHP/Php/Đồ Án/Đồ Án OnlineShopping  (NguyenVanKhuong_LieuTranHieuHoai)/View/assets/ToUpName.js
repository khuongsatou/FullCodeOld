
function UpdateNameFist(id) {
	
	var string = document.getElementById(id).value;
	var result = string.charAt(0).toUpperCase() + string.slice(1);
	document.getElementById(id).value = result;
}

function UpdateNameLast(id) {
   var str = document.getElementById(id).value;
   var splitStr = str.toLowerCase().split(' ');
   for (var i = 0; i < splitStr.length; i++) {
       splitStr[i] = splitStr[i].charAt(0).toUpperCase() + splitStr[i].substring(1);     
   }
   document.getElementById(id).value = splitStr.join(' '); 
}
