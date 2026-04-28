<template>
  <div>
    <!-- Header -->
    <div class="container-fluid custom-header">
      <h2 @click="toggleMenu" class="menu-icon">
        <a href="/">
          <img src="../../../public/images/logo.svg" height="30" />
        </a>
      </h2>
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

  .custom-header h2 img {
      margin-left: 10px;
  }

  .menu-icon {
    color: white;
    cursor: pointer;
    width: fit-content;
  }



  .menu-title {
    margin-bottom: 20px;
    border-bottom: 1px solid #ffffff33;
    padding-bottom: 10px;
  }

 
</style>
