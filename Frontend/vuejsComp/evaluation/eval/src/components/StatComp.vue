<script>
    import { eva } from '../assets/store.js'
    export default {
        data(){
            return{

            }
        },
        computed: {
            getLength(){
                
                return eva.value.gradesLength
            },
            getThreshold(){
                return eva.value.threshold
            },
            getAverage(){
                return eva.value.average
            },
            getStudentsAboveAverage(){
                let counter = 0;
                if(eva.value.grades != null){
                    eva.value.grades.forEach(element => {
                        if(element > eva.value.average){
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