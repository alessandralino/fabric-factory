import { createApp } from 'vue';
import App from './App.vue';
import router from './routes'; // Importe o arquivo de rotas que você configurou

const app = createApp(App);

app.use(router); // Use o Vue Router

app.mount('#app');
