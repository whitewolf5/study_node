		var str = 'abcABC123DDD3124';
        var regexp = /[\d]+/gi; // g:전역검색, i:대소문자구분함.
        var dataset = []; //배열선언

		var matches_array = str.match(regexp);
		
        matches_array.forEach((obj) => {
			dataset.push(obj);
		});

        //객체 타입확인
        console.log('obj type1=',typeof str);
        console.log('obj type2=',typeof dataset);

        // 배열사이즈 체크
        if (dataset && dataset.length > 0) {
            console.log(dataset);
            console.log(dataset.join(':')); //배열을 연결시킴, 파라메터에 연결스트링은 옵션(',')
        }