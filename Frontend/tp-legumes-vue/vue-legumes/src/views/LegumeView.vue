<script setup>
import { onMounted } from "vue";
import Vegetables from '../components/LegumeComp.vue'

onMounted(() => {
  document.querySelectorAll('th').forEach(th_elem => {
    let asc = true
    th_elem.setAttribute('title', 'Tri descendant')
    let index = Array.from(th_elem.parentNode.children).indexOf(th_elem)
    th_elem.addEventListener('click', () => {            
      th_elem.setAttribute('title', asc ? 'Tri ascendant' : 'Tri descendant') 
      const arr = [... th_elem.closest("table").querySelectorAll('tbody tr')]
      arr.sort( (a, b) => {
        let a_value = a.children[index].innerText
        let b_value = b.children[index].innerText
        if(index === 3 || index === 5){
          return (asc) ? b_value - a_value : a_value - b_value
        }else{
          return (asc) ? b_value.localeCompare(a_value) : a_value.localeCompare(b_value)
        }
      })
      arr.forEach(elem => {                   
        th_elem.closest("table").querySelector("tbody").appendChild(elem)
      })
      asc = !asc
    })
  })
})

</script>

<template>
  <h1>Liste des légumes</h1>
  <table>
    <thead>
      <th>Nom</th>
      <th>Variété</th>
      <th>Couleur</th>
      <th>Durée Conservation</th>
      <th>Frais</th>
      <th>Prix (€)</th>
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
  h1{
    margin: 20px;
  }

  table{
    width: 80%;
    margin: 25px auto;
    color: blue;
  }

  th{
    background-color: var(--main-green);
    color: var(--txt-yellow);
    cursor: pointer;
  }
</style>
