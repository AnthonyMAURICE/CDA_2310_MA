

<template>
    <h1>Ajouter une vente</h1>
    <form id="add-form">
        <fieldset>
            <legend>Nouvelle vente</legend>
            <label for="name">Nom : </label>
            <input type="text" id="name" required>
            <label for="variety">Variété : </label>
            <input type="text" id="variety" required>
            <label for="date">Date : </label>
            <input type="date" id="date">
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

button{
    width: 10rem;
}
</style>