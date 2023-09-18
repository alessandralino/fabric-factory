// router.js
import { createRouter, createWebHistory } from 'vue-router';
import UploadPage from './components/UploadPage.vue';
import AddImagePopup from './components/AddImagePopup.vue';
import ItemList from './components/ItemList.vue';

const routes = [
  
  {
    path: '/',
    component: ItemList,
  },
  {
    path: '/upload/:itemId',
    name: 'upload',
    component: UploadPage,
  },
  {
    path: '/addImage/:itemId/:configIndex',
    name: 'addImage',
    component: AddImagePopup,
  },
  // Outras rotas do seu aplicativo
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
