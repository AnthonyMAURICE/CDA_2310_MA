<script setup>
import Vegetables from '../components/LegumeComp.vue'

</script>

<template>
  <table>
    <thead>
      <th>Nom</th>
      <th>Variété</th>
      <th>Couleur</th>
      <th>Durée Conservation</th>
      <th>Frais</th>
      <th>Prix</th>
      <th>Actions</th>
    </thead>
    <tbody>
      <Suspense>
        <Vegetables />
      </Suspense>
    </tbody>
  </table>
</template>

<style scoped>
  th{
    background-color: var(--main-green);
    color: var(--txt-yellow);
    padding: 0 15px;
  }
</style>
