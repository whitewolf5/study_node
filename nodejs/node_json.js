console.log('sample');

function a(){
    console.log('function a___');


    var json = '{"id": 1,"name": "A green door","price": 12.50,"tags": ["home", "green"]}';

    // JSON 문자열을 JavaScript 오브젝트로 변환한다. 주로 원격 서버로부터의 AJAX 응답시 반환 데이터를 변환하기 위해 사용한다.
    var object = JSON.parse(json);

    // JavaScript 오브젝트를 JSON 문자열로 변환한다. 주로 원격 서버에 AJAX 요청시 파라메터를 전달하기 위해 사용한다.
    var json = JSON.stringify(object);
    var json2 = JSON.stringify(object, null, 4); //트리형으로 보여준다.

    console.log(json);
    console.log(json2);
}
a();
