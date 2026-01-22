<script setup lang="ts">
  import axios from "axios";

  let inventoryData: InventoryModel[] = [];
  var textTesting: string = "asd";
  function textTestingType() {
    console.log('qwe')
    textTesting = "awasd";
  }

  //async function getAll () {

  //  console.log("testing")
  //  try {
  //    const response = await axios.get("https://localhost:44329/Inventory");

  //    var data = response.data.result;
  //    return data;
  //  }
  //  catch (error) {
  //    console.log(error);
  //  }

  //}

  

  var isTestingMode = false;

  interface InventoryModel {
    id: number,
    decription: string,
    quantity: number,
    image: string,
  }

  console.log("el valor fuera del get all 1");
  console.log(inventoryData);

  //getAll().then(x => {
  //  console.log("el valor dentro del get all 2");
  //  console.log(x);

  //  inventoryData = x;
  //}).catch(err => {
  //  console.log(err);
  //}).finally();

  console.log("el valor fuera del get all 3");
  console.log(inventoryData);


  
</script>

<template>
  <div class="container">

    <div class="row">
      <div class="col-6 offset-3">
        <div class="input-group">
          <span class="input-group-text" id="basic-addon1"><i class="bi bi-search"></i></span>
          <input class="form-control" type="search" placeholder="Busqueda" id="gsearch" name="gsearch">
        </div>
      </div>

      <div class="col offset-1">
        <input type="button" class="btn btn-primary" value="Agregar">
      </div>
    </div>

    <input type="text" @input="textTestingType" />

    {{textTesting}}
    {{inventoryData}}

    <div class="row table-responsive table-scroll-container">
      <table class="table table-hover">
        <thead>
          <tr>
            <th> ID </th>
            <th>DESCRIPCION</th>
            <th>CANTIDAD</th>
            <th>IMAGEN</th>
            <th>DETALLES</th>
          </tr>
        </thead>

        <tbody>

          <tr v-for="item in inventoryData">
            <td> {{item.id}} </td>
            <td> {{item.description}}</td>
            <td> {{item.quantity}} </td>
            <td> {{item.image}} </td>
            <td>
              <input type="button" value="i" />
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

  .table-responsive{
      max-height:500px;
  }

  .table-scroll-container{
      overflow-y: auto;
      display:block;
  }

  .table-scroll-container thead th{
      position:sticky;
      top:0;
      z-index: 10;
      
  }

  
</style>
