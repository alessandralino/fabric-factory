<!-- CustomcustomModal.vue -->
<template>
    <div class="customModal">
      <div class="customModal-content">
        <!-- Aqui você pode incluir o conteúdo do seu componente -->
        <slot>teste</slot>
      </div>
    </div>
  </template>
  
  <style scoped>
    /* Estilos CSS para o modal */
    .customModal {
      position: fixed;
      top: 0;
      left: 0;
      width: 100%;
      height: 100%;
      background-color: rgba(0, 0, 0, 0.5);
      display: flex;
      justify-content: center;
      align-items: center;
    }
  
    .customModal-content {
      background-color: white;
      padding: 20px;
      border-radius: 5px;
    }
  </style>
  