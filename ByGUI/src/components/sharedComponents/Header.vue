<template>
  <div class="header-blue-line"></div>

  <div class="header-search">
    <transition name="fade" mode="out-in">
      <img :key="hover"
           :src="hover
          ? '/images/logoDeBusquedaVariante.svg'
          : '/images/logoSearch.svg'"
           height="50"
           @mouseenter="hover = true"
           @mouseleave="hover = false"
           @click="emit('toggleSearch')" />
    </transition>
  </div>
</template>

<script setup lang="ts">
  import { ref } from 'vue'

  const hover = ref(false)
  const fading = ref(false)

  const emit = defineEmits(['toggleSearch'])

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
  .fade-enter-active,
  .fade-leave-active {
    transition: opacity 0.25s ease;
  }

  .fade-enter-from,
  .fade-leave-to {
    opacity: 0;
  }

  img {
    cursor: pointer;
  }

</style>
