<script>
    import result from '../assets/fetchData.js'
    import Student from '../assets/Student.js'
    import calcAvg from '../assets/calcAvg.js'
    export default {
        data(){
            return{
                data: [],
                threshold: 12
            }
        },
        mounted(){
            for(let elem of result){
                let student = new Student(elem.fullname.split(' ')[0], elem.fullname.split(' ')[1], elem.grade)
                this.data.push(student)
                this.data.sort((a, b) => b.grade - a.grade)
            }
            
        },
        methods:{
            passed(){
                let counter = 0
                for(let elem of this.data){
                    if(elem.grade > this.average){
                        counter++
                    }
                }
                return counter
            }
        }
    }
    
</script>
    
<template>
    <tbody>
        <tr v-for="elem in data">
            <td v-for="items in elem">{{ items }}</td>
            <td>{{ elem.grade >= threshold ? 'oui' : 'non' }}</td>
        </tr>
    </tbody>
    
</template>

<style>
td{
    border: 1px solid var(--color2);
    padding: 5px;
}
</style>