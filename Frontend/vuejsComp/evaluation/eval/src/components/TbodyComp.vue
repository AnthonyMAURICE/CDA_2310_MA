<script>
    //import result from '../assets/fetchData.js'
    import Student from '../assets/Student.js'
    import Evaluation from '../assets/Evaluation.js';
    import { eva, resultArray, data } from '../assets/store.js'
    export default {
        data(){
            return{
                students: data.value,
                gradeArray: [],
                eval: null
            }
        },
        mounted(){
            if(resultArray.value != null){
                for(let elem of resultArray.value){
                    let student = new Student(elem.fullname.split(' ')[0], elem.fullname.split(' ')[1], elem.grade)
                    this.students.push(student)
                }
                this.students.sort((a, b) => b.grade - a.grade)
                resultArray.value.forEach(element => {
                        this.gradeArray.push(element.grade)
                });
                this.eval = new Evaluation(12, this.gradeArray)
                eva.value = this.eval
                console.log(eva.value)
            }
        },
    }
    
</script>
    
<template>
    <tbody>
        <tr v-for="student in students">
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