<script setup>
import { usePokemonStore } from '@/stores/pokemonStore'; // นำเข้า store จากไฟล์ pokemonStore เพื่อดึงข้อมูลโปเกมอน
import { ref, onMounted } from 'vue'; // นำเข้า ref และ onMounted จาก Vue

let get_data = ref([]); // สร้างตัวแปร get_data เพื่อเก็บข้อมูล โดยใช้ ref สำหรับ reactive data
const store = usePokemonStore(); // เรียกใช้งาน store

// ฟังก์ชันที่ใช้ในการดึงข้อมูลจาก store
const getData = async () => {
  await store.fetchPokemons(); // เรียกฟังก์ชัน fetchPokemons จาก store เพื่อดึงข้อมูลโปเกมอน
  get_data.value = store.pokemons; // เก็บข้อมูลที่ดึงมาได้ในตัวแปร get_data
}
// เรียกใช้ฟังก์ชัน getData เมื่อคอมโพเนนต์ถูกติดตั้งแล้ว
onMounted(() => {
  getData(); // เรียกใช้ฟังก์ชัน getData เมื่อคอมโพเนนต์ถูกติดตั้งแล้ว
});
</script>

<template>
  <div class="pokemon-grid">
    <div v-for="(item, index) in get_data" :key="index" class="pokemon-item">
      <h3>{{ item.name }}</h3>
      <img :src="item.sprites.front_default" alt="pokemon image" />
    </div>
  </div>
</template>

<style scoped>
.pokemon-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
  gap: 16px;
}
.pokemon-item {
  border: 1px solid #ccc;
  padding: 16px;
  text-align: center;
}
</style>
