<script setup lang="ts">
  var inventoryData: InventoryModel [] = [];

  var isTestingMode = true;

  interface InventoryModel {
    ID: number,
    DESCRIPTION: string,
    QUANTITY: number,
    IMAGE: string,
  }
  if (isTestingMode) {
    alert("Esta en modo de prueba: Datos falsos");

    const inventoryMockDataRecords: InventoryModel[] = [];
    inventoryMockDataRecords.push({ ID:0, DESCRIPTION: "BRK 356 satinado",QUANTITY: 1,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:1, DESCRIPTION: "BRK 420 satinado",QUANTITY: 11,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:2, DESCRIPTION: "BRK 1364 satinado",QUANTITY: 12,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:3, DESCRIPTION: "BRK 123 satinado",QUANTITY: 16,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:4, DESCRIPTION: "BRK 422 satinado",QUANTITY: 4,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:5, DESCRIPTION: "BRK 344 satinado",QUANTITY: 7,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:6, DESCRIPTION: "BRK 578 satinado",QUANTITY: 8,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:7, DESCRIPTION: "BRK 975 satinado",QUANTITY: 3,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:8, DESCRIPTION: "BRK 645 satinado",QUANTITY: 1,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:9, DESCRIPTION: "BRK 345 satinado",QUANTITY: 5,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:10, DESCRIPTION: "BRK 6654 satinado",QUANTITY: 9,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:11, DESCRIPTION: "BRK 653 satinado",QUANTITY: 3,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:12, DESCRIPTION: "BRK 436 satinado",QUANTITY: 2,IMAGE: "imagen"});
    inventoryMockDataRecords.push({ ID:13, DESCRIPTION: "BRK 834 satinado",QUANTITY: 8,IMAGE: "imagen"});

    inventoryData = inventoryMockDataRecords;
  }


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


    <div class="row table-responsive table-scroll-container">
      <table class="table table-hover">
        <thead >
          <tr>
            <th> ID </th>
            <th>DESCRIPCION</th>
            <th>CANTIDAD</th>
            <th>IMAGEN</th>
            <th>DETALLES</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="item in inventoryData ">
            <td> {{item.ID}} </td>
            <td> {{item.DESCRIPTION}}</td>
            <td> {{item.QUANTITY}} </td>
            <td> {{item.IMAGE}} </td>
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
