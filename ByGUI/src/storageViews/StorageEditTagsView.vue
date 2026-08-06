<script setup lang="ts">
  import type { TagModel } from "@/interFaces/tagsModel"
  import { useTagsStore } from '@/setup/tagsService'
  import { useRouter, useRoute } from "vue-router";
  import axios from "axios";
  import { ref, onMounted } from "vue";



  const tagsStore = useTagsStore();
  const $route = useRoute();
  const $router = useRouter();


  // function goTo(route: string) {
  //   $router.push("/" + route);
  // }



  const newTag = ref({
    details: "",
    color: "",
    icon: ""
  });

  interface tagViewModel{
    details: "",
    color: "",
    icon: ""
  };

  interface InventoryTagsViewModel {
    inventarioId: number;
    details: string;
    tagList: tagViewModel[];
  }

  function goToEdit( Id: number) {
    console.log("Ir a:", $route);
    $router.push( 'inventarioEditar' + "?id=" + Id)
  }



  const inventoryTagsData = ref<InventoryTagsViewModel[]>([]);

  async function getInventarioTags(viewModelId: any) {
    try {
      const response = await axios.get(`https://localhost:44329/Inventory/GetTags/${viewModelId}`);
      inventoryTagsData.value = response.data;
    } catch (error) {
      console.error(error);
    }
  }

  const viewModelId: number = Number($route.query.inventarioId);

    getInventarioTags(viewModelId);
  
  async function updateTags() {
    try {
      await axios.put(
        `https://localhost:44329/Inventory/UpdateInventoryTags/${viewModelId}`,
        tagsStore.tags
      );
    } catch (error) {
      console.error(error);
    } finally {
      goToEdit(viewModelId);
    }
  }


</script>

<template>
  <div class="container page-container">
    <div class="card shadow p-4 tag-box">

      <h3 class="text-center mb-4">
        Administrar Tags de: {{inventoryTagsData.details}}
      </h3>

      <div v-for="(tag,index) in tagsStore.tags"
           :key="index"
           class="tag-row">

        <input class="form-check-input"
               type="checkbox"
               v-model="tag.isEnable" />

        <div class="preview-tag"
             :style="{ backgroundColor: '#' + tag.color }">
          {{ tag.details }}
          <i :class="`bi bi-${tag.icon}`"></i>
        </div>


      </div>

      <hr>

      <h5 class="mb-3">
        Nuevo Tag
      </h5>

      <div class="mb-3">
        <label class="form-label">
          Detalle
        </label>

        <input class="form-control"
               v-model="newTag.details" />
      </div>

      <div class="mb-3">
        <label class="form-label">
          Color (Hexadecimal)
        </label>

        <input class="form-control"
               placeholder="FFFFFF"
               v-model="newTag.color" />
      </div>

      <div class="mb-4">
        <label class="form-label">
          Icono
        </label>

        <input class="form-control"
               placeholder="gear"
               v-model="newTag.icon" />
      </div>

      <button class="btn btn-warning w-100"
              @click="updateTags">
        Actualizar
      </button>

    </div>

  </div>
</template>


<style scoped>


  .tag-box {
    width: 500px;
    max-width: 95%;
    border-radius: 12px;
  }

  .tag-box {
    width: 500px;
    max-width: 95%;
    border-radius: 12px;
  }

  .tag-row {
    display: flex;
    align-items: center;
    gap: 15px;
    margin-bottom: 12px;
  }

  .preview-tag {
    display: inline-flex;
    align-items: center;
    gap: 8px;
    color: white;
    padding: 6px 14px;
    border-radius: 8px;
    font-weight: 600;
    min-width: 180px;
  }

    .preview-tag i {
      font-size: 1rem;
    }

  .page-container {
    display: flex;
    justify-content: center;
    padding-top: 25px; /* Barra (200px) + separación */
    padding-bottom: 40px;
  }
</style>
