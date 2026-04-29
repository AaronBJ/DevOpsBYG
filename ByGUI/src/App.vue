<script setup lang="ts">
import HelloWorld from './components/HelloWorld.vue'
  import TheWelcome from './components/TheWelcome.vue'
  import sharedHeader from "./components/sharedComponents/Header.vue"
  import bottomMenu from "./components/sharedComponents/BottomMenu.vue"
</script>

<template>
  <sharedHeader />
  <div class="container">
    <router-view />
  </div>
  <bottomMenu/>
</template>

<style scoped>
header {
  line-height: 1.5;
}

  .container {
    padding-bottom: 80px; /* altura del bottom menu */
  }

.logo {
  display: block;
  margin: 0 auto 2rem;
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
}
</style>
