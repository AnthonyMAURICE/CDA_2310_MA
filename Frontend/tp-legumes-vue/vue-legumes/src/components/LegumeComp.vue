<script setup>

async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json')
    const data = await response.json()
    return data
}

const vegetables = await fetchData()
</script>

<template>
    <tr class="row" v-for="vegetable in vegetables">    
        <td>{{ vegetable.Name }}</td>
        <td>{{ vegetable.Variety }}</td>
        <td>{{ vegetable.PrimaryColor }}</td>
        <td>{{ vegetable.LifeTime }}</td>
        <td v-if="vegetable.Fresh == 0">Non</td>
        <td v-else> Oui</td>
        <td>{{ vegetable.Price }} </td>
        <td>
            <button>Editer</button>
            <p> - </p>
            <button>Supprimer</button>
        </td>
    </tr>
</template>


