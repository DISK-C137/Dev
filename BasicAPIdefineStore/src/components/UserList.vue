<template>
    <div>
      <div v-if="loading">Loading...</div>
      <div v-if="error">Error: {{ error.message }}</div>
      <div v-if="data && data.length">
        <ul>
          <li v-for="user in data" :key="user.id">
            <p><strong>Name:</strong> {{ user.name }}</p>
            <p><strong>Email:</strong> {{ user.email }}</p>
            <!-- แสดงข้อมูลอื่นๆ ตามที่ API ให้มา -->
          </li>
        </ul>
      </div>
      <div v-else-if="data && data.length === 0">No users found.</div>
    </div>
  </template>
  
  <script>
  import { useMainStore } from '@/stores/basicStore'; // ปรับเส้นทางให้ตรงกับที่เก็บไฟล์ store
  import { defineComponent, onMounted } from 'vue';
  
  export default defineComponent({
    setup() {
      const store = useMainStore();
  
      // เรียก fetchData ทันทีที่ component ถูกสร้างขึ้น
      onMounted(() => {
        store.fetchData();
      });
  
      return {
        data: store.data,
        loading: store.loading,
        error: store.error,
      };
    },
  });
  </script>
  
  <style scoped>
  /* เพิ่มสไตล์ที่คุณต้องการที่นี่ */
  ul {
    list-style-type: none;
    padding: 0;
  }
  
  li {
    margin-bottom: 15px;
  }
  </style>
  