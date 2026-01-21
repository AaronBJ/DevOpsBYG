<script setup lang="ts">
</script>

<template>
    <div class="container">

      <div class="row">
        <div class="col-6 offset-3" >
          <div class="input-group">
            <span class="input-group-text" id="basic-addon1"><i class="bi bi-search"></i></span>
            <input class="form-control" type="search" placeholder="Busqueda" id="gsearch" name="gsearch">
          </div>
        </div>

        <div class="col offset-1">
          <input type="button" class="btn btn-primary" value="Agregar">
        </div>
      </div>

      <div class="row">

        <label for="id">ID</label>
        &nbsp;
        <label for="desc">DESCRIPCION</label>
        &nbsp;
        <label for="cant">CANTIDAD</label>
        &nbsp;
        <label for="img">IMAGEN</label>
        <hr>

      </div>

      <div class="row">

        <input type="number" id="id" name="id" />
        &nbsp;
        <input type="text" id="desc" name="desc" />
        &nbsp;
        <input type="number" id="cant" name="cant" />
        &nbsp;
        <input type="image" />
        &nbsp;
        <input type="button" value="Detalles" />
        <br />
        <input type="button" value="Editar" />
        &nbsp;
        <input type="button" value="Eliminar" />
        <hr />

      </div>

      <div class="row">
        <input type="button" value="Ver todos" />
      </div>

      <div class="row">
        <label for="nregis">numero de registros por pagina:</label>
      </div>

      <div class="row">
        <input type="number" id="nregis" name="nregis" />
      </div>

      <div class="row">
        1 2 3 4 5 6 7 ...
      </div>


    </div>
</template>

<style scoped>
  header {
    line-height: 1.5;
  }

  
</style>
