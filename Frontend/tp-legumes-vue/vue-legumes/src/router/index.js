import { createRouter, createWebHistory } from 'vue-router'
import LegumeView from '../views/LegumeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: LegumeView
    },
    {
      path: '/ventes',
      name: 'ventes',
      component: () => import('../views/VenteView.vue')
    },
    {
      path: '/addLegume',
      name: 'addLegume',
      component: () => import('../views/AddLegumeView.vue')
    },
    {
      path: '/addSale',
      name: 'addSale',
      component: () => import('../views/AddSaleView.vue')
    }
  ]
})

export default router
