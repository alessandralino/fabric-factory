<template>
    <div>
      <h1>Upload Page</h1>
      <div v-if="item">
        <h2>Item ID: {{ item.id }}</h2>
        <h3>Item Name: {{ item.name }}</h3>
        <div>
          <h4>Product Configurations:</h4>
          <div v-for="(config, index) in itemConfigurations" :key="index">
            <p>Color: {{ config.color }}</p>
            <p>Fabric: {{ config.fabric }}</p>
            <button @click="openAddImagePopup(index)">Add Image</button>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        item: null, // Current item data
        itemConfigurations: [], // Product configurations for the item
      };
    },
    created() {
      // Fetch the item data and configurations for the specified item ID
      const itemId = this.$route.params.itemId; // Get the item ID from the route parameter
      this.fetchItem(itemId);
    },
    methods: {
      fetchItem(itemId) {
        // Simulate fetching item data from a REST API based on the item ID
        // Replace this with actual API call
        setTimeout(() => {
          this.item = {
            id: itemId,
            name: 'Sample Item',
          };
  
          this.itemConfigurations = [
            { color: 'Red', fabric: 'Cotton' },
            { color: 'Blue', fabric: 'Silk' },
            // Add more configurations as needed
          ];
        }, 1000); // Simulated delay
      },
      openAddImagePopup(index) {
        // Navigate to the AddImagePopup component and pass the item and configuration index
        this.$router.push({
          name: 'addImage',
          params: { itemId: this.item.id, configIndex: index },
        });
      },
    },
  };
  </script>
  