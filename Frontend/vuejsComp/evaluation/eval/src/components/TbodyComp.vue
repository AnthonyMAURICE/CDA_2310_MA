<script>
    import result from '../assets/fetchData.js'
    import Student from '../assets/Student.js'
    import calcAvg from '../assets/calcAvg.js'
    import Evaluation from '@/assets/Evaluation.js';
    export default {
        data(){
            return{
                data: [],
                evaluation: new Evaluation(12, calcAvg)
            }
        },
        mounted(){
            for(let elem of result){
                let student = new Student(elem.fullname.split(' ')[0], elem.fullname.split(' ')[1], elem.grade)
                this.data.push(student)
            }
            this.data.sort((a, b) => b.grade - a.grade)
        },
    }
    
</script>
    
<template>
    <tbody>
        <tr v-for="student in data">
            <td>{{ student.lName }}</td>
            <td>{{ student.fName }}</td>
            <td>{{ student.grade }}</td>
            <td>{{ student.grade >= evaluation.threshold ? 'oui' : 'non' }}</td>
        </tr>
    </tbody>
</template>

<style>
td{
    border: 1px solid var(--color2);
    padding: 5px;
}
</style>