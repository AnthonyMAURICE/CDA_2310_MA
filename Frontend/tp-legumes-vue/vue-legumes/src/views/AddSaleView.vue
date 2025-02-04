<script setup>
import { ref } from 'vue'
import {storedSale} from '../assets/store.js'

let storeSale = localStorage
const salesId = ref(storedSale.sales.length + 1)

let salesArray = []

if(localStorage.getItem('Sales') !== null){
    let file = JSON.parse(storeSale.getItem('Sales'))
    salesArray = file
}


const savedSale = {
    Id: salesId.value,
    Name: '',
    SaleWeight: '',
    SaleDate: ''
}


function increment(){
    salesId.value++
}

function addingSale(){
    increment()
    salesArray.push(savedSale)
    storeSale.setItem('Sales', JSON.stringify(salesArray))
}
</script>

<template>
    <h1>Ajouter une vente</h1>
    <form id="add-form">
        <fieldset>
            <legend>Nouvelle vente</legend>
            <label for="name">Nom : </label>
            <input v-model="savedSale.Name" type="text" id="name" required>
            <label for="weight">Poids de la vente : </label>
            <input v-model="savedSale.SaleWeight" type="number" id="weight" required>
            <label for="date">Date : </label>
            <input v-model="savedSale.SaleDate" type="date" id="date" required>
            <button @click="addingSale">Ajouter</button>
        </fieldset>
    </form>
</template>

<style scoped>

fieldset{
    display: flex;
    flex-flow: column;
    width: 50%;
    margin: auto;
}

.radio{
    padding: 1rem;
}

button{
    width: 10rem;
}
</style>