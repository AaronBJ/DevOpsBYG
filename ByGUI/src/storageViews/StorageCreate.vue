<script setup lang="ts">
  import axios from "axios";
  import { ref, onMounted } from "vue";

  interface InventoryModel {
    id: number;
    description: string;
    quantity: number;
    image: string;
  }

  const inventoryData = ref<InventoryModel[]>([]);

 /* async function getAll() {
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
  */

</script>

<template>
  <div class="container">
    <div class="row">
      <div class="col-12 text-center">
        <h1>Agregar a inventario</h1>
      </div>
    </div>
    <div class="row">
      <div class="col-12">
        <form>
          <div class="row">
            <div class="col-12">
              <label for="descr">Descripcion:</label>
              <input placeholder="Descripcion " class="form-control" type="text" id="descr" name="descr" />
            </div>
          </div>

          <div class="row">
            <div class="col-6">
              <label for="quant">Cantidad:</label>
              <input placeholder="Cantidad" class="form-control" type="number" id="quant" name="quant" />
            </div>
            <div class="col-6">
              <label for="img">Imagen:</label>
              <input class="form-control" type="text" id="img" name="img" />
            </div>
          </div>
          <br />
          <div class="row">
            <div class="col-12">
              <input class="btn btn-primary w-100" type="submit" value="agregar" />
            </div>
          </div>

        </form>
      </div>
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
