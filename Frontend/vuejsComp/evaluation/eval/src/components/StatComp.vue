<script>
    import { eva } from '../assets/store.js'
    export default {
        data(){
            return{
                eval: eva
            }
        },
        computed: {
            getLength(){
                return this.eval.value != null ? this.eval.value.length : 0
            },
            getThreshold(){
                return this.eval.value != null ? this.eval.value.threshold : 0
            },
            getAverage(){
                return this.eval.value != null ? this.eval.value.average : 0
            },
            getStudentsAboveAverage(){
                let counter = 0;
                if(this.eval.value != null){
                    this.eval.value.grades.forEach(element => {
                        if(element > this.eval.value.average){
                            counter++
                        }
                    });
                }
                    
                return counter
            }
        },
        methods:{

        },
        
    }
</script>
    
<template>
    <ul>
        <li>Nombre d'étudiants : {{ getLength }}</li>
        <li>Moyenne de la classe : {{ getAverage }}</li>
        <li>Nombre d'étudiants au dessus de la moyenne : {{ getStudentsAboveAverage }}</li>
        <li>Note éliminatoire : {{ getThreshold }}</li>
    </ul>
</template>

<style>

</style>