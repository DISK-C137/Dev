<script setup>
import moment from "moment"; // นำเข้าไลบรารี moment สำหรับจัดการวันที่
import { userStore } from "../src/stores/counter"; // นำเข้า store จากไฟล์ counter เพื่อดึงข้อมูลผู้ใช้
import { ref, onMounted } from "vue"; // นำเข้า ref และ onMounted จาก Vue

let get_data = ref([]); // สร้างตัวแปร get_data เพื่อเก็บข้อมูล โดยใช้ ref สำหรับ reactive data
const store = userStore(); // เรียกใช้งาน store

// ฟังก์ชันที่ใช้ในการดึงข้อมูลจาก store
const getData = async () => {
  const data = await store.getData(); // เรียกฟังก์ชัน getData จาก store เพื่อดึงข้อมูล
  get_data.value = data.data; // เก็บข้อมูลที่ดึงมาได้ในตัวแปร get_data
  //console.log(data); // สามารถเปิดคอมเมนต์บรรทัดนี้เพื่อดีบั๊กข้อมูลที่ได้
}

// ฟังก์ชันที่ใช้ในการแปลงวันที่ให้เป็นรูปแบบที่ต้องการ
const convertDate = (date) => {
  let year = moment(date).year() + 543; // แปลงปีคริสต์ศักราชเป็นพุทธศักราช
  return moment(date).format('DD/MM/' + year); // คืนค่าเป็นวันที่ในรูปแบบ DD/MM/พ.ศ.
}

// เรียกใช้ฟังก์ชัน getData เมื่อคอมโพเนนต์ถูกติดตั้งแล้ว
onMounted(() => {
  getData(); // เรียกใช้ฟังก์ชัน getData เมื่อคอมโพเนนต์ถูกติดตั้งแล้ว
});
</script>

<template>
  <ul>
    <!-- วนลูปแสดงข้อมูลจาก get_data -->
    <li v-for="(item, index) in get_data" :key="index">
      <p>{{ item.name }}</p> <!-- แสดงชื่อของผู้ใช้ -->
      <p>{{ convertDate(item.createdAt) }}</p> <!-- แสดงวันที่สร้างในรูปแบบที่แปลงแล้ว -->
      <img :src="item.avatar" alt="Avatar"> <!-- แสดงภาพโปรไฟล์ของผู้ใช้ -->
    </li>
  </ul>
</template>

<style scoped>
/* คุณสามารถเพิ่ม CSS สำหรับสไตล์ของคอมโพเนนต์นี้ที่นี่ */
</style>
