function f1(callback){
    callback();
}

var v1 = [1, 2, 3, 5];

//람다식으로 f1을 호출함
f1(() => {
    console.log('test2');
});