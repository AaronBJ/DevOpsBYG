<template>
  <div>
    <!-- Header -->
    <div class="container-fluid custom-header">
      <div class="menu-icon">
        <a href="/">
          <img src="../../../public/images/logo.svg" height="30" />
        </a>
        <a href="/inventario">
          <i class="bi bi-journal-text header-icons" ></i>
        </a>
      </div> 
    </div>

  </div>
</template>

<script>
  export default {
    name: "Home",
  };
</script>

<style scoped>
  .custom-header {
    background-color: #204375;
    padding: 10px;
  }

  .custom-header div img {
      margin-left: 10px;
  }

  .menu-icon {
    display: flex;
    align-items: center; /* 🔥 esto los alinea perfectamente */
    gap: 20px; /* reemplaza margin-left */
    color: white;
    cursor: pointer;
    margin-top: 10px;
    margin-bottom: 10px;
  }
  .header-icons {
    color: #162F52;
    text-shadow: 1px 1px 0px rgba(0,0,0,0.5);
    font-size: 33px;
  }



  .menu-title {
    margin-bottom: 20px;
    border-bottom: 1px solid #ffffff33;
    padding-bottom: 10px;
  }

 
</style>
