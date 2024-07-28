<script setup>
import moment from "moment";
import { userStore } from "../src/stores/counter" // ดึงข้อมูลจาก Store
import { ref, onMounted } from "vue"

let get_data = ref([]) // ตัวแปรที่ใช้เก็บข้อมูล
const store = userStore()

const getData = async () => {
  const data = await store.getData() // เรียกข้อมูลจาก store
  get_data.value = data.data // เก็บข้อมูลลงในตัวแปร get_data
  //console.log(data) // สามารถเปิดคอมเมนต์เพื่อดีบั๊กได้
}

const convertDate = (date) => {
  let year = moment(date).year() + 543
  return moment().format('DD/MM/'+year)
}

onMounted(() => {
  getData() // เรียกใช้ฟังก์ชัน getData เมื่อคอมโพเนนต์ถูกติดตั้งแล้ว
})
</script>

<template>
  <ul>
    <li v-for="(item, index) in get_data" :key="index">
      <p>{{ item.name }}</p> <!-- แสดงชื่อของผู้ใช้ -->
      <p>{{ convertDate(item.createdAt) }}</p> <!-- แสดงวันที่สร้าง -->
      <img :src="item.avatar" alt="Avatar"> <!-- แสดงภาพโปรไฟล์ -->
    </li>
  </ul>
</template>

<style scoped></style>
