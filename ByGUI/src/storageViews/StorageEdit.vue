<script setup lang="ts">
import axios from "axios";
import { ref, onMounted } from "vue";
import { useRouter, useRoute } from "vue-router";

const router = useRouter();
const route = useRoute();

interface InventoryModel {
  id: number;
  description: string;
  quantity: number;
  image: string;
}




function goTo(route: string) {
  router.push("/" + route);
}

/* ViewModel */
const viewModelId = route.query.id;
const viewModelDescription = ref<string>("");
const viewModelQuantity = ref<number>(0);
const viewModelImage = ref<string>("");



/* Cargar datos al entrar 
onMounted(async () => {
  try {
    const id = Number(route.params.id);
    const response = await axios.get(`https://localhost:44329/Inventory/${id}`);

    viewModelId.value = response.data.id;
    viewModelDescription.value = response.data.description;
    viewModelQuantity.value = response.data.quantity;
    viewModelImage.value = response.data.image;

  } catch (error) {
    console.error(error);
  }
});

/* Actualizar */
async function updateOnClick() {
  const data: InventoryModel = {
    id: viewModelId.value,
    description: viewModelDescription.value,
    quantity: viewModelQuantity.value,
    image: viewModelImage.value
  };

  try {
    await axios.put(`https://localhost:44329/Inventory/${data.id}`, data);
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
      <div class="col-12 text-center">
        <h1>Editar inventario</h1>
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

          <div class="row">
            <div class="col-12">
              <input class="btn btn-warning w-100"
                     type="button"
                     value="Actualizar"
                     @click="updateOnClick" />
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>
