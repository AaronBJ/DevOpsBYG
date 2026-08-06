<script setup lang="ts">
  import axios from "axios";
  import { ref, onMounted } from "vue";
  import { useRouter, useRoute } from 'vue-router';


  const router = useRouter();
  const route = useRoute();

  function getTagStyle(tag: any) {
    return {
      backgroundColor: `#${tag.color}`,
      color: 'white',
      padding: '4px 8px',
      borderRadius: '8px',
      marginRight: '5px'
    }
  }

  function getTagStyleDot(tag: any) {
    return {
      color: `#${tag.color}`,
      padding: '4px 1px',
      borderRadius: '8px',
      fontSize: '10px'
    }
  }

  interface InventoryModel {
    id: number;
    description: string;
    quantity: number;
    image: string;
    tags: string[];
  }

  function goToEdit(route: string, Id:number) {
    console.log("Ir a:", route);
    //router.push({ name: route, params: { Id: Id } });
    router.push(route + "?id="+Id)
  }

  function goTo(route: string) {
    console.log("Ir a:", route);
    router.push ('/' + route)
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

  async function deleted(id: number) {
    try {
      const response = await axios.delete(`https://localhost:44329/Inventory/${id}`);
    } catch (error) {
      console.log(error);
    } finally {
      getAll();
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
            <th>IMAGEN</th>
            <th>DESCRIPCION</th>
            <th>CANTIDAD</th>
            <th>OPCIONES</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="item in inventoryData" :key="item.id">
            <td class="cell-highlight">{{ item.id }}</td>
            <td>

              <div class="description-image">
                <img v-if="item.image"
                     :src="`/mediafiles/${item.image}`"
                     alt="imagen"
                     height="40" />

              </div>

            </td>

            <td>


              <div class="description-box">
                <div class="description-content">
                  <div class="description-title">
                    {{ item.description }}
                  
                    <i v-for="tag in item.tags" class="bi bi-circle-fill" :style="getTagStyleDot(tag)" ></i>
                  
                  </div>
                </div>


              </div>
            </td>

            <td class="cell-highlight">{{ item.quantity }}</td>
            <td>
              <button type="button" @click="goToEdit('inventarioEditar', item.id)" class="btn btn-primary btn-inventory bi bi-chevron-bar-expand" title="detalles">
              <!--<i class="bi bi-pen "></i>-->
              </button>
              &nbsp;
              <button type="button" @click="deleted(item.id)" class="btn btn-danger bi bi-slash-circle padding-boton-rojo" title="eliminar" >
              <!--<i class="bi bi-trash"></i>-->
              </button>
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
  .description-box {
    display: flex;
    justify-content: space-between;
    align-items: center;
    border: 1px solid #dee2e6;
    border-radius: 12px;
    padding: 0px 16px;
    padding-top: 4px;
    background-color: #f8f9fa;
    box-shadow: 0 2px 4px rgba(0,0,0,0.05);
    transition: all 0.2s ease-in-out;
  }

    .description-box:hover {
      box-shadow: 0 4px 8px rgba(0,0,0,0.08);
    }

  .description-content {
    width: 70%;
  }

  .description-title {
    font-weight: 700;
    font-size: 15px;
    margin-bottom: 6px;
  }

  .description-tags {
    margin-bottom: 6px;
  }

  .description-image {
    width: 30%;
    display: flex;
    justify-content: center;
    align-items: center;
  }

    .description-image img {
      max-width: 100%;
      max-height: 80px;
      object-fit: contain;
      border-radius: 8px;
    }

  .cell-highlight {
    font-weight: 700;
    font-size: 15px;
    vertical-align: middle !important;
  }

  tbody td {
    vertical-align: middle;
  }

  .btn-inventory{
      padding-top: 0px;
      padding-bottom: 0px;
  }

  .padding-boton-rojo{
      padding-top: 0px;
      padding-bottom: 0px;
  }
  
</style>
