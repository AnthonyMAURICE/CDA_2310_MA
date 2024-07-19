<script>
import { data } from '../assets/store.js'
export default {
    
    data(){
        return{
            name: '',
            grade: 0,
            students: data,
            student: {
                fullname: '',
                grade: 0
            }
        }
    },
    methods:{
        addStudent(){
            if(this.checkGradeValidity() && this.checkNameValidity()){
                let tempElem = ''
                let tempName = this.name.toLowerCase().split(' ')
                tempName = this.capitalizeFirstLetter(tempName)
                tempName = tempElem.split('-')
                tempName = this.capitalizeFirstLetter(tempName)
                tempElem = tempName[0] + '-' + tempName[1]
                this.student.fullname = tempElem
                this.student.grade = this.grade
                console.log(this.student)
            }else{
                this.name = 'Error detected'
            }
        },
        capitalizeFirstLetter(array){
            for(let elem of array){
                array += elem.charAt(0).toUpperCase() + elem.slice(1) + " "
            }
            return array
        },
        checkNameValidity(){
            const regex = /^[a-zA-Z][a-zA-Z0-9-_ \.]{1,}$/
            return regex.test(this.name)
        },
        checkGradeValidity(){
            return (this.grade >= 0 && this.grade <= 20) ? true : false
        }
    }
}
</script>

<template>
    <form action="">
        <h2>Ajouter une note</h2>
        <div class="inputs">
            <label for="name">Nom Prénom</label>
            <input type="text" name="name" id="name" v-model="name">
        </div>
        <div class="inputs">
            <label for="grade">Note</label>
            <input type="number" name="grade" id="grade" v-model="grade">
        </div>
        <button @click="addStudent" type="button">Ajouter</button>
    </form>
</template>

<style scoped>
    form{
        display: flex;
        flex-direction: column;
        width: 75%;
        border: 1px dashed var(--color2);
        padding: 15px;
        margin: 10px 0; 
    }

    .inputs{
        width: 40%;
        display: flex;
        justify-content: space-between;
    }

    button{
        background-color: var(--color4);
        color: var(--color3);
        width: 10%;
    }
</style>