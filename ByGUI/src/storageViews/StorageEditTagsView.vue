<!--<script setup lang="ts">
  import { ref } from "vue";
  import type { TagModel } from "@/interFaces/tagsModel"


const newTag = ref({
    details: "",
    color: "",
    icon: ""
});

function updateTags(){

}
</script>-->

<template>
  <div class="container vh-100 d-flex justify-content-center align-items-center">

    <div class="card shadow p-4 tag-box">

      <h3 class="text-center mb-4">
        Administrar Tags
      </h3>

      <!--<div v-for="(tag,index) in tagsStore.tags"
           :key="index"
           class="tag-row">

        <input class="form-check-input"
               type="checkbox"
               v-model="tag.enabled">

        <div class="preview-tag"
             :style="{ backgroundColor: '#' + tag.color }">
          {{ tag.details }}
          <i :class="`bi bi-${tag.icon}`"></i>
        </div>

      </div>-->

      <hr>

      <h5 class="mb-3">
        Nuevo Tag
      </h5>

      <div class="mb-3">
        <label class="form-label">
          Detalle
        </label>

        <!--<input class="form-control"
               v-model="newTag.details">-->
      </div>

      <div class="mb-3">
        <label class="form-label">
          Color (Hexadecimal)
        </label>

        <!--<input class="form-control"
               placeholder="FFFFFF"
               v-model="newTag.color">-->
      </div>

      <div class="mb-4">
        <label class="form-label">
          Icono
        </label>

        <!--<input class="form-control"
               placeholder="gear"
               v-model="newTag.icon">-->
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
</style>
