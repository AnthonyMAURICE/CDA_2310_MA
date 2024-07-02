<script setup>
import { ref } from "vue"
import {store} from '../assets/store.js'
let storeItem = localStorage

const identifiers = ref(store.vegetables.length + 1)
let savedArray = []

if(localStorage.getItem("Addition") !== null){
    let file = JSON.parse(storeItem.getItem('Addition'))
    savedArray = file
}

const saved = {
    Id: identifiers.value,
    Name: '',
    Variety: '',
    PrimaryColor: '',
    LifeTime: '',
    Fresh: false,
    Price: 0
}

function increment(){
    identifiers.value++
}

function adding(){
    increment()
    savedArray.push(saved)
    storeItem.setItem('Addition', JSON.stringify(savedArray))
}
    
</script>

<template>
    <h1>Ajouter un légume</h1>
    <form id="add-form">
        <fieldset>
            <legend>Nouveau Légume</legend>
            <label for="name">Nom : </label>
            <input v-model="saved.Name" type="text" id="name" required>
            <label for="variety">Variété : </label>
            <input v-model="saved.Variety" type="text" id="variety" required>
            <label for="color">Couleur : </label>
            <input v-model="saved.PrimaryColor" type="text" id="color" required>
            <label for="lifetime">Durée de Conservation : </label>
            <input v-model="saved.LifeTime" type="number" id="lifetime" required>
            <label for="price">Prix : </label>
            <input v-model="saved.Price" type="number" id="price" required>
            <p>Frais : 
                <label class="radio" for="fresh">Oui</label>
                <input type="radio" id="fresh" name="fresh">
                <label class="radio" for="not-fresh">Non</label>
                <input type="radio" id="not-fresh" name="fresh">
            </p>
            <button @click="adding" form="add-form">Ajouter</button>
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
</style>