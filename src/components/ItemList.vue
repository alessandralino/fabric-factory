<template>
    <div>
      <h1>Fabric Factory</h1>
      <table class="item-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Total Colors</th>
            <th>Total Fabrics</th>
            <th>Total Images</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in items" :key="item.id">
            <td>{{ item.id }}</td>
            <td>{{ item.name }}</td>
            <td>{{ item.colors.length }}</td>
            <td>{{ item.fabrics.length }}</td>
            <td>{{ getTotalImages(item) }}</td>
            <td>
                <button @click="showModal = true">Edit Images</button>
            </td>

            <CustomModal v-if="showModal">
      <h2>Item ID: {{ item.id }}</h2>
      <h3>Item Name: {{ item.name }}</h3>
      <!-- Outros conteúdos do seu componente -->
      <button @click="showModal = false">Close</button>
    </CustomModal>
          </tr>
        </tbody>
      </table>

      
    </div>
  </template>
  
  <script>
  import CustomModal from './CustomModal.vue'; // Importe o componente CustomModal
  export default {
    components: {
    CustomModal,
  },
    data() {
      return {
        showModal: false,
        items: [], // Array to store the list of items
      };
    },
    created() {
      // Fetch the list of items from your database API here
      // You can use Axios or any other HTTP library
      this.fetchItems();
    },
    methods: {
      fetchItems() {
        // Simulate fetching items from a REST API
        // Replace this with actual API call
        setTimeout(() => {
          this.items = [
            {
              id: 1,
              name: 'Item 1',
              colors: ['Red', 'Blue'],
              fabrics: ['Cotton', 'Silk'],
              images: ['image1.jpg', 'image2.jpg'],
            },
            {
              id: 2,
              name: 'Item 2',
              colors: ['Green', 'Yellow'],
              fabrics: ['Polyester', 'Linen'],
              images: ['image3.jpg', 'image4.jpg'],
            },
            // Add more items as needed
          ];
        }, 1000); // Simulated delay
      },
      getTotalImages(item) {
        return item.images.length;
      },
    },
  };
  </script>
  
  <style scoped>
  .item-table {
    width: 100%;
    border-collapse: collapse;
  }
  
  .item-table th,
  .item-table td {
    border: 1px solid #ccc;
    padding: 8px;
    text-align: left;
  }
  
  .item-table th {
    background-color: #f2f2f2;
    font-weight: bold;
  }
  </style>
  