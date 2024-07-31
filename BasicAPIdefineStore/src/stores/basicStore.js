import { defineStore } from 'pinia';
import axios from 'axios';

export const useMainStore = defineStore('main', {
  state: () => ({
    data: null,
    loading: false,
    error: null,
  }),
  actions: {
    async fetchData() {
      this.loading = true;
      try {
        const response = await axios.get('https://66a6790223b29e17a1a2c205.mockapi.io/user');
        this.data = response.data;
      } catch (error) {
        this.error = error;
      } finally {
        this.loading = false;
      }
    },
  },
});
