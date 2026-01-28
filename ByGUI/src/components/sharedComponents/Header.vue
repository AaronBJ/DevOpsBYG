<template>
  <div>
    <!-- Header -->
    <div class="container-fluid custom-header">
      <h2 @click="toggleMenu" class="menu-icon">
        <i class="bi bi-list"></i>
      </h2>
    </div>

    <!-- Overlay oscuro -->
    <div v-if="menuOpen"
         class="overlay"
         @click="toggleMenu"></div>

    <!-- Menú lateral -->
    <div :class="['side-menu', { open: menuOpen }]">
      <h4 class="menu-title">Menú</h4>
      <ul>
        <li @click="goTo('')"><i class="bi bi-house"></i> Inicio</li>
        <li @click="goTo('inventario')"><i class="bi bi-archive"></i> Inventario</li>
        <!--<li @click="goTo('configuracion')">⚙️ Configuración</li>
        <li @click="goTo('logout')">🚪 Cerrar sesión</li>-->
      </ul>
    </div>
  </div>
</template>

<script>
  export default {
    name: "Home",
    data() {
      return {
        menuOpen: false
      };
    },
    methods: {
      toggleMenu() {
        this.menuOpen = !this.menuOpen;
      },
      goTo(route) {
        this.menuOpen = false;
        console.log("Ir a:", route);
         this.$router.push('/' + route)
      }
    }
  };
</script>

<style scoped>
  .custom-header {
    background-color: darkslategrey;
    padding: 10px;
  }

  .menu-icon {
    color: white;
    cursor: pointer;
    width: fit-content;
  }

  /* overlay oscuro */
  .overlay {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    z-index: 998;
  }

  /* menú lateral */
  .side-menu {
    position: fixed;
    top: 0;
    left: 0;
    height: 100%;
    width: 260px;
    background: #2f4f4f;
    color: white;
    padding: 20px;
    transform: translateX(-100%);
    transition: transform 0.3s ease-in-out;
    z-index: 999;
  }

    /* cuando se abre */
    .side-menu.open {
      transform: translateX(0);
    }

  .menu-title {
    margin-bottom: 20px;
    border-bottom: 1px solid #ffffff33;
    padding-bottom: 10px;
  }

  .side-menu ul {
    list-style: none;
    padding: 0;
  }

  .side-menu li {
    padding: 12px 0;
    cursor: pointer;
    font-size: 16px;
  }

    .side-menu li:hover {
      background: rgba(255, 255, 255, 0.15);
      padding-left: 10px;
      transition: 0.2s;
    }
</style>
