<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Banner from './components/BannerComp.vue'
</script>

<template>
  <header>
    <div class="wrapper">
      <Banner />
      <nav>
        <ul class="nav-elem">
          <li><RouterLink to="/ventes">VENTES</RouterLink></li>
          <li><RouterLink to="/addSale">NOUVELLE VENTE</RouterLink></li>
        </ul>
        <ul class="nav-elem">
          <li><RouterLink to="/">LÉGUMES</RouterLink></li>
          <li><RouterLink to="/addLegume">NOUVEAU LÉGUME</RouterLink></li>
        </ul>
      </nav>
    </div>
  </header>

  <RouterView />
</template>

<style scoped>

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  height: 3.5rem;
}

.nav-elem{
  display: flex;
  align-items: center;
  list-style: none;
}

.nav-elem a{
  display: flex;
  color: var(--color-text);
  padding: 1rem;
  align-items: center;
}

li{
  color: white;
}

li:hover{
  background-color: lightgreen;
  color: black;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    font-size: 1rem;
    height: 4.5rem;
  }
}
</style>
