<script>
    import result from '../assets/fetchData.js'
    import calcAvg from '../assets/calcAvg.js'
    
    export default {
        data(){
            return{
                average: 0,
                gradeArray: []
            }
        },
        mounted(){
            result.forEach(element => {
                    this.gradeArray.push(element.grade)
            });
            this.average = calcAvg(this.gradeArray)
        },
        methods:{
            passed(){
                let counter = 0
                for(let elem of result){
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
    <ul>
        <li>Nombre d'étudiants : {{ gradeArray.length }}</li>
        <li>Moyenne de la classe : {{ average }}</li>
        <li>Nombre d'étudiants au dessus de la moyenne : {{ passed() }}</li>
    </ul>
</template>

<style>

</style>