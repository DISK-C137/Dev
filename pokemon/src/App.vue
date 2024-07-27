<template>
  <div id="app">
    <!-- แทรกคอมโพเนนต์ MyNavbar และรับ event การค้นหา -->
    <MyNavbar @search="handleSearch" />

    <!-- ใช้ Tailwind CSS เพื่อจัดรูปแบบและแสดงผล Pokémon -->
    <div class="p-6 bg-gray-100 min-h-screen">
      <!-- หัวข้อหลักของหน้า -->
      <h1 class="text-4xl font-bold text-center mb-4">Pokémon List</h1>
      <!-- ใช้ grid layout เพื่อจัดการการแสดงผล Pokémon เป็นคอลัมน์ -->
      <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4">
        <!-- วนลูปแสดง Pokémon แต่ละตัวในรูปแบบ card -->
        <div v-for="pokemon in filteredPokemons" :key="pokemon.id" class="bg-white p-4 rounded-lg shadow-md">
          <!-- รูปภาพของ Pokémon -->
          <img :src="pokemon.sprites.front_default" :alt="pokemon.name" class="w-full h-auto mb-2 rounded">
          <!-- ชื่อของ Pokémon -->
          <h2 class="text-lg font-semibold text-center">{{ "Name: " + pokemon.name }}</h2>
          <!-- ประเภทของ Pokémon -->
          <h2 class="text-lg font-semibold text-center">{{ "Types: " + pokemon.types.map(type => type.type.name).join(', ') }}</h2>
          <!-- ความสามารถของ Pokémon -->
          <h2 class="text-lg font-semibold text-center">{{ "Abilities: " + pokemon.abilities.map(ability => ability.ability.name).join(', ') }}</h2>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios'; // นำเข้า axios สำหรับการทำ HTTP requests
import MyNavbar from './components/MyNavbar.vue'; // นำเข้า MyNavbar คอมโพเนนต์

export default {
  components: {
    MyNavbar, // ลงทะเบียนคอมโพเนนต์ MyNavbar เพื่อใช้ในเทมเพลต
  },
  data() {
    return {
      pokemons: [], // เก็บข้อมูล Pokémon ที่ดึงมาจาก API
      searchTerm: '', // เก็บคำค้นหาจากกล่องค้นหา
    };
  },
  computed: {
    filteredPokemons() {
      // ฟิลเตอร์ Pokémon ตามค่าการค้นหา
      const term = this.searchTerm.toLowerCase(); // แปลงคำค้นหาเป็นตัวพิมพ์เล็ก
      return this.pokemons.filter(pokemon =>
        pokemon.name.toLowerCase().includes(term) // ตรวจสอบว่าชื่อของ Pokémon มีคำค้นหาหรือไม่
      );
    }
  },
  mounted() {
    this.fetchPokemons(); // เรียกใช้ฟังก์ชัน fetchPokemons เมื่อคอมโพเนนต์ถูกติดตั้ง
  },
  methods: {
    async fetchPokemons() {
      try {
        const requests = []; // สร้าง array สำหรับเก็บ HTTP requests
        for (let i = 1; i <= 50; i++) {
          // สร้าง requests เพื่อดึงข้อมูล Pokémon จาก API
          requests.push(axios.get(`https://pokeapi.co/api/v2/pokemon/${i}`));
        }
        const responses = await Promise.all(requests); // รอให้ทุก request เสร็จสมบูรณ์
        this.pokemons = responses.map(response => response.data); // เก็บข้อมูล Pokémon ใน state
      } catch (error) {
        // จัดการข้อผิดพลาดหากมีปัญหาในการดึงข้อมูล
        console.error('Error fetching Pokémon:', error);
      }
    },
    handleSearch(searchTerm) {
      // อัพเดตค่าการค้นหา
      this.searchTerm = searchTerm;
    }
  }
}
</script>

<style></style>
