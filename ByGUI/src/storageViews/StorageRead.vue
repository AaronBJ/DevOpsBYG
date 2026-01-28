<script setup lang="ts">
  import axios from "axios";
  import { ref, onMounted } from "vue";
  import { useRouter } from 'vue-router';

  const router = useRouter();

  interface InventoryModel {
    id: number;
    description: string;
    quantity: number;
    image: string;
  }

  function goTo(route:string) {
    console.log("Ir a:", route);
    router.push('/' + route)
  }

  const inventoryData = ref<InventoryModel[]>([]);

  async function getAll() {
    try {
      const response = await axios.get("https://localhost:44329/Inventory");
      inventoryData.value = response.data; // <- aquí
    } catch (error) {
      console.log(error);
    }
  }

  onMounted(() => {
    getAll();
  });
</script>

<template>
  <div class="container">
    <div class="row">
      <div class="col-6 offset-3">
        <div class="input-group">
          <span class="input-group-text" id="basic-addon1"><i class="bi bi-search"></i></span>
          <input class="form-control" type="search" placeholder="Busqueda" id="gsearch" name="gsearch" />
        </div>
      </div>

      <div class="col offset-1">
        <input @click="goTo('inventarioCrear')" type="button" class="btn btn-primary" value="Agregar" />
      </div>
    </div>



    <div class="row table-responsive table-scroll-container">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>ID</th>
            <th>DESCRIPCION</th>
            <th>CANTIDAD</th>
            <th>IMAGEN</th>
            <th>DETALLES</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="item in inventoryData" :key="item.id">
            <td>{{ item.id }}</td>
            <td>{{ item.description }}</td>
            <td>{{ item.quantity }}</td>
            <td>{{ item.image }}</td>
            <td><button type="button" class="btn btn-primary" title="detalles" ><i class="bi bi-info-circle text-blue"></i></button>


            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<style scoped>
  header {
    line-height: 1.5;
  }

  .table-responsive {
    max-height: 500px;
  }

  .table-scroll-container {
    overflow-y: auto;
    display: block;
  }

    .table-scroll-container thead th {
      position: sticky;
      top: 0;
      z-index: 10;
    }
</style>
