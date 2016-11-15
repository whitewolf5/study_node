function f1(callback){
    callback();
}


f1(function(){
    console.log('test1');
});


f1(() => {
    console.log('test2');
});


var fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.sort();
fruits.reverse();

console.log(fruits);