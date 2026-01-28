import { createRouter, createWebHistory } from 'vue-router'
import homeVue from './homeViews/Home.vue'

export default createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: '/',
      component: homeVue,
    },
    {
      path: '/inventario',
      component: () => import('./storageViews/StorageRead.vue'),
    },
    {
      path: '/inventarioCrear',
      component: () => import('./storageViews/StorageCreate.vue'),
    },
    {
      path: '/inventarioEditar',
      component: () => import('./storageViews/StorageEdit.vue'),
    }
  ],
})
