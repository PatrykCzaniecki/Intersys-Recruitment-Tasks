function optionalPow(a, b){
    let response = prompt('Press OK if agree or press Cancel if does not agree');
    let result;
    if(response == 'OK'){
        result = Math.pow(a, b);
    }else if(response == 'Cancel'){
        result = Math.pow(b, a);
    }
    return result;
}