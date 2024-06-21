<script setup>
    import Sales from '../components/VenteComp.vue'
</script>

<template>
    <h1>Liste des ventes</h1>
    <section>
        <Suspense>
            <Sales />
        </Suspense>
    </section>
    
</template>

<style scoped>

    section{
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
    }
    h1{
        margin: 20px;
    }
</style>