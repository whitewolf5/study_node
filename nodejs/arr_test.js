
var menu = [["menu1", "menu2", "menu3", "menu4"], ["1", "2", "3", "4"], ["a1", "a2", "a3", "a4"]];
var menu2 = [["menu5", "menu6", "menu7", "menu8"], ["5", "6", "7", "8"], ["b5", "b6", "b7", "b8"]];
var dataset = [];

for(i=0; i<menu.length; i++){
	dataset.push(menu[i].concat(menu2[i]));
}

console.log(Math.min(1, 2));
console.log(dataset);


