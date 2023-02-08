function fixAge(ages){
    let validAges = [];
    for(let i = 0; i < ages.length; i++){
        if(ages[i] >= 18 && ages[i] <= 60){
            validAges.push(ages[i]);
        }
    }
    if(validAges.length === 0){
        return "NA";
    }
    return validAges.join(",");
}