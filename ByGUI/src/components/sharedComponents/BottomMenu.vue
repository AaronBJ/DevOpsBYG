<template>
  <div>
    <div class="container-fluid custom-bottom-menu">
      <div class="menu-icon">
        <a href="/">
          <img src="../../../public/images/logo.svg" height="30" />
        </a>
        <a href="/inventario">
          <i class="bi bi-journal-text bottom-menu-icons"></i>
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
  .custom-bottom-menu {
    background-color: #204375;
    padding-left: 10px;
    position: fixed;
    bottom: 0;
    left: 0;
    width: 100%;
    z-index: 1000; /* para que quede encima */
  }

    .custom-bottom-menu div img {
      margin-left: 10px;
    }

  .menu-icon {
    display: flex;
    align-items: center; /* 🔥 esto los alinea perfectamente */
    gap: 20px; /* reemplaza margin-left */
    color: white;
    cursor: pointer;
    margin-top: 5px;
    margin-bottom: 5px;
  }

  .bottom-menu-icons {
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
