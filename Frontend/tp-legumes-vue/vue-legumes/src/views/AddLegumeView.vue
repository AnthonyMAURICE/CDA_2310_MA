<script setup>

</script>

<template>
    <h1>Ajouter un légume</h1>
    <form id="add-form">
        <fieldset>
            <legend>Nouveau Légume</legend>
            <label for="name">Nom : </label>
            <input type="text" id="name" required>
            <label for="variety">Variété : </label>
            <input type="text" id="variety" required>
            <label for="color">Couleur : </label>
            <input type="text" id="color" required>
            <label for="lifetime">Durée de Conservation : </label>
            <input type="number" id="lifetime" required>
            <p>Frais : 
                <label class="radio" for="fresh">Oui</label>
                <input type="radio" id="fresh" name="fresh">
                <label class="radio" for="not-fresh">Non</label>
                <input type="radio" id="not-fresh" name="fresh">
            </p>
            <button type="submit" form="add-form">Ajouter</button>
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