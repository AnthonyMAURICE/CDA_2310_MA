<script setup>
import { computed } from 'vue'

    async function fetchData(){
        const response = await fetch('https://arfp.github.io/tp/web/javascript2/11-grocery/legumos-sales.json')
        const data = await response.json()
        return data
    }

    const sales = await fetchData()

    const openSales = computed(() => {
        return sales.filter(i => i.SaleActive)
    })
    
    function dateFormat(_date){
        _date = _date.split("-")
        return _date[2] + "/" + _date[1] + "/" + _date[0]
    }
        
</script>

<template>
    <div class="sales" v-for="items in openSales">
        <p class="bold">{{ items.Name.charAt(0).toUpperCase() + items.Name.slice(1)  }}</p>
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

    .bold{
        font-size: 2rem;
        font-weight: 800;
    }

    .date{
        margin-top: 1.7rem;
    }
</style>