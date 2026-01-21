<script setup lang="ts">
</script>

<template>
  <header>

    <div>
      <form>
        <label for="gsearch">Busqueda:</label>
        <input type="search" id="gsearch" name="gsearch">
      </form>
      <br />
      <input type="button" value="Agregar">
      <br />
      <hr />
      <label for="id">ID</label>
      &nbsp;
      <label for="desc">DESCRIPCION</label>
      &nbsp;
      <label for="cant">CANTIDAD</label>
      &nbsp;
      <label for="img">IMAGEN</label>
      <hr>
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
  </header>

</template>

<style scoped>
  header {
    line-height: 1.5;
  }

  
</style>
