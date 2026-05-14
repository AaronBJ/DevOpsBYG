<template>
  <transition name="overlay-fade">
    <div v-if="visible"
         class="overlay"
         @click.self="close">
      <div class="search-panel">

        <!-- Input -->
        <input v-model="query"
               type="text"
               placeholder="Buscar módulos..."
               class="search-input" />

        <!-- Resultados -->
        <div class="results">

          <div v-for="item in filteredData"
               :key="item['title']"
               class="result-item"
               @click="goTo(item['link'])">
            <img :src="`/mediafiles/${item.image}`"
                 class="result-img" />

            <div class="result-info">

              <span class="title">
                {{ item["title"] }}
              </span>

              <span class="category"
                    :style="{ backgroundColor: item['category-color'] }">
                {{ item["category"] }}
              </span>

            </div>

          </div>

        </div>

      </div>
    </div>
  </transition>
</template>

<script setup lang="ts">
  import { ref, computed } from 'vue'
  import axios from "axios";

  const props = defineProps<{
    visible: boolean
  }>()

  const emit = defineEmits(['close'])

  const query = ref('')

  interface SearchIaModel {
    image: string;
    categoryColor: string;
    title: string;
    category: number;
    link: string;

  }

  var data : SearchIaModel[];

  async function getAll() {
    try {
      const response = await axios.get("https://localhost:44329/Ia");
      data = response.data; // <- aquí
    } catch (error) {
      console.log(error);
    }
  }

  getAll();

  const filteredData = computed(() => {
    return data.filter(item =>
      item["title"]
        .toLowerCase()
        .includes(query.value.toLowerCase())
    )
  })

  const close = () => {
    emit('close')
  }

  const goTo = (url: string) => {
    window.location.href = url
  }
</script>

<style scoped>
  .overlay {
    position: fixed;
    inset: 0;
    background: rgba(0,0,0,0.65);
    backdrop-filter: blur(8px);
    display: flex;
    justify-content: center;
    align-items: flex-start;
    padding-top: 100px;
    z-index: 9999;
  }

  .search-panel {
    width: 90%;
    max-width: 650px;
    background: white;
    border-radius: 22px;
    padding: 20px;
    box-shadow: 0 20px 50px rgba(0,0,0,0.25);
  }

  .search-input {
    width: 100%;
    padding: 14px 18px;
    border: none;
    outline: none;
    border-radius: 14px;
    background: #F1F5F9;
    font-size: 16px;
    margin-bottom: 20px;
  }

  .results {
    display: flex;
    flex-direction: column;
    gap: 10px;
    max-height: 400px;
    overflow-y: auto;
  }

  .result-item {
    display: flex;
    align-items: center;
    gap: 14px;
    padding: 12px;
    border-radius: 14px;
    cursor: pointer;
    transition: background 0.2s ease, transform 0.2s ease;
  }

    .result-item:hover {
      background: #F8FAFC;
      transform: scale(1.01);
    }

  .result-img {
    width: 45px;
    height: 45px;
    border-radius: 10px;
  }

  .result-info {
    display: flex;
    flex-direction: column;
    gap: 5px;
  }

  .title {
    font-weight: 600;
  }

  .category {
    width: fit-content;
    color: white;
    font-size: 12px;
    padding: 4px 8px;
    border-radius: 999px;
  }

  .overlay-fade-enter-active,
  .overlay-fade-leave-active {
    transition: opacity 0.25s ease;
  }

  .overlay-fade-enter-from,
  .overlay-fade-leave-to {
    opacity: 0;
  }
</style>
