function calcAvg(_arrayOfValues){
    let globalNote = 0
    for(let value of _arrayOfValues){
        globalNote += value
    }
    return globalNote/_arrayOfValues.length
}

export default calcAvg