class Evaluation{
    constructor(_threshold, _grades){
        this.threshold = _threshold
        this.grades = _grades
    }

    average(){
        let sum = 0
        for(let value of this.grades){
            sum += value
        }
        return sum/this.grades.length
    }
}

export default Evaluation