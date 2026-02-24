<script setup lang="ts">
import axios from "axios";
import { ref, onMounted } from "vue";
import { useRouter, useRoute } from "vue-router";

const $router = useRouter();
const $route = useRoute();

  interface TagModel {
    id: number;
    details: string;
    color: string;
    icon: string;
  }

  interface InventoryModel {
    id: number;
    description: string;
    quantity: number;
    image: string;
    tags: TagModel[];
  }

  const viewModelTags = ref<TagModel[]>([]);


  function goToInventory(route: string) {
    $router.push('/inventario')
  }

function goTo(route: string) {
  $router.push("/" + route);
}

  /* ViewModel */
  const viewModelId = $route.query.id;
const viewModelDescription = ref<string>("");
const viewModelQuantity = ref<number>(0);
  const viewModelImage = ref<string>("");

  function addTag() {
    viewModelTags.value.push({
      id: 0,
      details: "",
      color: "",
      icon: ""
    });
  }

  function removeTag(index: number) {
    viewModelTags.value.splice(index, 1);
  }





  /* Cargar datos al entrar */

onMounted(async () => {
  try {
    await $router.isReady();
    console.log($route);
    console.log($route.query);
    console.log($route.query.id);
    const id = $route.query.id;
    const response = await axios.get(`https://localhost:44329/Inventory/${id}`);
    viewModelTags.value = response.data.tags ?? [];


    viewModelDescription.value = response.data.description;
    viewModelQuantity.value = response.data.quantity;
    viewModelImage.value = response.data.image;

  } catch (error) {
    console.error(error);
  }
});

/* Actualizar */
  async function updateOnClick(viewModelId: number) {
    const data: InventoryModel = {
      id: viewModelId,
      description: viewModelDescription.value,
      quantity: viewModelQuantity.value,
      image: viewModelImage.value,
      tags: viewModelTags.value
    };

    try {
      await axios.put(
        `https://localhost:44329/Inventory/${data.id}`,
        data
      );
    } catch (error) {
      console.error(error);
    } finally {
      goTo("inventario");
    }
  }
</script>

<template>
  <div class="container">
    <div class="row">
      <div class="col-6 offset-3 o text-center">
        <h1>Editar inventario</h1>
      </div>

      <div class="col-3">
        <button class="float-rigth btn btn-danger" @click="goToInventory('inventario')" >regresar</button>
      </div>
    </div>

    <div class="row">
      <div class="col-12">
        <form>
          <div class="row">
            <div class="col-12">
              <label>ID:</label>
              <input class="form-control"
                     type="text"
                     readonly
                     v-model="viewModelId" />
            </div>
          </div>
          <div class="row">
            <div class="col-12">
              <label>Descripción:</label>
              <input class="form-control"
                     type="text"
                     v-model="viewModelDescription" />
            </div>
          </div>

          <div class="row">
            <div class="col-6">
              <label>Cantidad:</label>
              <input class="form-control"
                     type="number"
                     v-model="viewModelQuantity" />
            </div>
            <div class="col-6">
              <label>Imagen:</label>
              <input class="form-control"
                     type="text"
                     v-model="viewModelImage" />
            </div>
          </div>

          <br />
          <hr />

          <div class="row">
            <div class="col-12">
              <h5>Tags</h5>
            </div>
          </div>

          <div v-for="(tag, index) in viewModelTags" :key="index" class="row mb-2">

            <div class="col-3">
              <input class="form-control"
                     placeholder="Detalle"
                     v-model="tag.details" />
            </div>

            <div class="col-3">
              <input class="form-control"
                     placeholder="Color (ej: FF0000)"
                     v-model="tag.color" />
            </div>

            <div class="col-3">
              <input class="form-control"
                     placeholder="Icon (ej: gear)"
                     v-model="tag.icon" />
            </div>

            <div class="col-3 d-flex align-items-end">
              <button type="button"
                      class="btn btn-danger w-100"
                      @click="removeTag(index)">
                Eliminar
              </button>
            </div>

          </div>

          <div class="row">
            <div class="col-12">
              <button type="button"
                      class="btn btn-primary w-100"
                      @click="addTag">
                + Agregar Tag
              </button>
            </div>
          </div>
          <br />
          <hr />
          <div class="row">
            <div class="col-12">
              <input class="btn btn-warning w-100"
                     type="button"
                     value="Actualizar"
                     @click="updateOnClick(viewModelId)" />
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<style>

  .float-rigth{
    float:right;
  }
</style>
