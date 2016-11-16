function f1(callback){
    callback();
}

//f1을 호출함, 파라메터가 function임.
f1(function(){
    console.log('test1');
});

//람다식으로 f1을 호출함
f1(() => {
    console.log('test2');
});


var fruits = ["Banana", "Orange", "Apple", "Mango"];
var number = [3, 5, 7, 2];
fruits.sort(); //abc순서로 정렬
//fruits.reverse(); //배열의 뒤부터 정렬

number.sort((a, b)=>{return b-a;}); //값의 역순으로 정렬. 단,값이 문자열이면 안되더라는...
//위와동일 설명용 // number.sort(function(v1, v2){console.log(v1, v2); return v2-v1});

console.log(fruits);
console.log(number);