import { defineStore } from 'pinia';
import axios from 'axios';

export const usePokemonStore = defineStore('pokemon', {
  state: () => ({
    pokemons: [],
  }),
  actions: {
    async fetchPokemons() {
      try {
        const response = await axios.get('https://pokeapi.co/api/v2/pokemon?limit=10');
        const results = response.data.results;

        const detailedPromises = results.map(result => axios.get(result.url));
        const detailedResponses = await Promise.all(detailedPromises);
        this.pokemons = detailedResponses.map(res => res.data);
      } catch (error) {
        console.error('Error fetching Pokemon data', error);
      }
    },
  },
});
