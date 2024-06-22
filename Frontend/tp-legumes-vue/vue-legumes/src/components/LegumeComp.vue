<script setup>
import {ref, onMounted} from 'vue';
let savedData = localStorage
const Id = ref(1);

async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json')
    const data = await response.json()
    return data
};

onMounted(() => {
    const rows = document.querySelectorAll('tr')
    for(let row of rows){
        row.setAttribute('id', Id.value)
        Id.value++
    }
})

let vegetables = await fetchData()
if(localStorage.getItem("data") !== null){
    let file = JSON.parse(savedData.getItem("data"))
    vegetables = vegetables.concat(file)
}

</script>

<template>
    <tr class="table-row" v-for="vegetable in vegetables">    
        <td>{{ vegetable.Name.charAt(0).toUpperCase() + vegetable.Name.slice(1) }}</td>
        <td>{{ vegetable.Variety.charAt(0).toUpperCase() + vegetable.Variety.slice(1) }}</td>
        <td>{{ vegetable.PrimaryColor }}</td>
        <td>{{ vegetable.LifeTime }}</td>
        <td v-if="vegetable.Fresh == 0">non</td>
        <td v-else> oui</td>
        <td>{{ vegetable.Price }}</td>
        <td>
            <p>
                <input id="btn-edit" class="btn-td" type="button" value="Editer">
                -
                <input id="btn-del" class="btn-td" type="button" value="Supprimer">
            </p>
        </td>
    </tr>
</template>

<style scoped>
    .btn-td{
        border: none;
        color: blue;
        cursor: pointer;
        background-color: transparent;
    }

    .btn-td:hover{
        text-decoration: underline
    }
</style>
