<script setup>
import { computed, onMounted } from 'vue'
import {storedSale} from '../assets/store.js'

let savedData = localStorage

    onMounted(() =>{
        if(localStorage.getItem('Sales') !== null){
            let files = JSON.parse(savedData.getItem('Sales'))
            for(let file of files){
                storedSale.sales.push(file)
            }
        }
    })


    const openSales = computed(() => {
        return storedSale.sales.filter(elem => elem.SaleActive != 0)
    })
    
    function dateFormat(_date){
        _date = _date.split("-")
        return `${_date[2]}/${_date[1]}/${_date[0]}`
    }

    function nameFormat(_name){
        return _name.charAt(0).toUpperCase() + _name.slice(1)
    }
        
</script>

<template>
    <div class="sales" v-for="items in openSales">
        <p class="bold">{{ nameFormat(items.Name) }}</p>
        <p class="bold">({{ items.SaleWeight }} kg)</p>
        <p class="date">{{ dateFormat(items.SaleDate) }}</p>
    </div>
</template>

<style scoped>
    div{
        display: flex;
        flex-flow: column;
        width: 25rem;
        height: 12rem;
        background-color: var(--main-green);
        color: white;
        margin: 1rem;
        align-items: center;
        justify-content: flex-start;
        padding: 1rem;
    }

    div:hover{
        background-color: lightgreen;
        color: black;
    }

    .bold{
        font-size: 2rem;
        font-weight: 800;
    }

    .date{
        margin-top: 1.7rem;
    }
</style>