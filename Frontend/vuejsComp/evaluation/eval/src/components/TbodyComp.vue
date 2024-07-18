<script>
    import result from '../assets/fetchData.js'
    import Student from '../assets/Student.js'
    import { eva, storedEval } from '../assets/store.js'
    export default {
        data(){
            return{
                data: [],
                gradeArray: [],
                eval: null
            }
        },
        mounted(){
            for(let elem of result){
                let student = new Student(elem.fullname.split(' ')[0], elem.fullname.split(' ')[1], elem.grade)
                this.data.push(student)
            }
            this.data.sort((a, b) => b.grade - a.grade)
            result.forEach(element => {
                    this.gradeArray.push(element.grade)
            });
            this.eval = eva.setEval(12, this.gradeArray)
            storedEval.value = this.eval
            console.log(storedEval)
        },
    }
    
</script>
    
<template>
    <tbody>
        <tr v-for="student in data">
            <td>{{ student.lName }}</td>
            <td>{{ student.fName }}</td>
            <td>{{ student.grade }}</td>
            <td>{{ student.grade >= eval.threshold ? 'oui' : 'non' }}</td>
        </tr>
    </tbody>
</template>

<style>
td{
    border: 1px solid var(--color2);
    padding: 5px;
}
</style>