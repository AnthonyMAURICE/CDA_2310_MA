function calcAvg(_arrayOfValues){
    let sum = 0
    for(let value of _arrayOfValues){
        sum += value
    }
    return sum/_arrayOfValues.length
}

export default calcAvg