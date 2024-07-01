<script setup>
    import { onMounted } from 'vue';
    import {store} from '../assets/store.js'
    let savedData = localStorage
    console.log(store.vegetables)
    onMounted(() => {
        const rows = document.querySelectorAll('tr')
        for(let i = 0; i < rows.length; i++){
            rows[i].setAttribute('id', store.vegetables[i].Id)
        }
    

        if(localStorage.getItem("Addition") !== null){
            let files = JSON.parse(savedData.getItem('Addition'))
            for(let file of files){
                store.vegetables.push(file)
            }
            console.log(store.vegetables)
        }
    })

    function nameFormat(_name){
        return _name.charAt(0).toUpperCase() + _name.slice(1)
    }
</script>

<template>
    <tr class="table-row" v-for="vegetable in store.vegetables">    
        <td>{{ nameFormat(vegetable.Name) }}</td>
        <td>{{ nameFormat(vegetable.Variety) }}</td>
        <td>{{ vegetable.PrimaryColor }}</td>
        <td>{{ vegetable.LifeTime }}</td>
        <td v-if="vegetable.Fresh == 0">non</td>
        <td v-else>oui</td>
        <td>{{ vegetable.Price }}</td>
        <td class="edit-suppr">
            <input class="input edit-input" type="button" value="Editer">
            -
            <input class="input suppr-input" type="button" value="Supprimer">
        </td>
    </tr>
</template>

<style scoped>
    .edit-suppr{
        display: flex;
        justify-content: space-evenly;
    }

    a{
        text-decoration: none
    }

    .input{
        border: none;
        background-color: transparent;
        color: blue;
    }

    .input:hover{
        text-decoration: underline;
        cursor: pointer;
    }
</style>
