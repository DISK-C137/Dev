<script setup>
import { usePokemonStore } from '@/stores/pokemonStore';
import { ref, onMounted } from 'vue';

let get_data = ref([]);
const store = usePokemonStore();

const getData = async () => {
  await store.fetchPokemons();
  get_data.value = store.pokemons;
}

onMounted(() => {
  getData();
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
