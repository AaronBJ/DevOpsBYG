<template>
  <div class="header-blue-line"></div>

  <div class="header-search">
    <img :class="{ fade: fading }"
         :src="hover ? '/images/logoDeBusquedaVariante.svg' : '/images/logoSearch.svg'"
         height="50"
         @mouseenter="handleEnter"
         @mouseleave="handleLeave" />
  </div>
</template>

<script setup lang="ts">
  import { ref } from 'vue'

  const hover = ref(false)
  const fading = ref(false)

  const handleEnter = () => {
    fading.value = true
    setTimeout(() => {
      hover.value = true
      fading.value = false
    }, 150)
  }

  const handleLeave = () => {
    fading.value = true
    setTimeout(() => {
      hover.value = false
      fading.value = false
    }, 150)
  }
</script>

<style scoped>
  .header-search {
    position: relative;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 70px;
  }



  .header-blue-line {
    height: 5px;
    background-color: #204375;
  }
  img {
    transition: opacity 0.3s ease;
  }

  .fade {
    opacity: 0;
  }

</style>
