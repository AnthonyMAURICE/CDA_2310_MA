class Evaluation{
    constructor(_threshold, _grades){
        this.threshold = _threshold
        this.grades = _grades
        this.average = this.average(this.grades)
    }

    average(gradesArray){
        let sum = 0
        for(let value of gradesArray){
            sum += value
        }
        return sum/gradesArray.length
    }
}

export default Evaluation