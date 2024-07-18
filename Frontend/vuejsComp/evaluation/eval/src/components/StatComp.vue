<script>
    import { storedEval } from '../assets/store.js'
    export default {
        data(){
            return{
                eval: null
            }
        },
        computed: {
            getLength(){
                console.log(storedEval.value)
            }
        },
        methods:{

        },
        
    }
</script>
    
<template>
    <ul>
        <li>Nombre d'étudiants : {{ getLength() }}</li>
        <li>Moyenne de la classe : {{ this.eval.average() }}</li>
        <li>Nombre d'étudiants au dessus de la moyenne : </li>
    </ul>
</template>

<style>

</style>