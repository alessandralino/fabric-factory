<template>
    <div>
      <h1>Item List</h1>
      <div v-for="item in items" :key="item.id">
        <div>
          <h2>{{ item.name }}</h2>
          <p>Item ID: {{ item.id }}</p>
          <p>Total Colors: {{ item.colors.length }}</p>
          <p>Total Fabrics: {{ item.fabrics.length }}</p>
          <p>Total Images: {{ getTotalImages(item) }}</p>
          <button @click="editPhotos(item)">Edit Photos</button>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
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
      editPhotos(item) {
        // Navigate to the UploadPage and pass the item ID
        this.$router.push({ name: 'upload', params: { itemId: item.id } });
      },
      getTotalImages(item) {
        return item.images.length;
      },
    },
  };
  </script>
  