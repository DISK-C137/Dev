import { defineStore } from "pinia";
import axios from "axios";
import moment from "moment";

// กำหนดและสร้าง Store สำหรับจัดการข้อมูลผู้ใช้งาน
export const userStore = defineStore({
  id: "userStore",
  state: () => ({
    material_url: {
      getmaterial: `https://66a6790223b29e17a1a2c205.mockapi.io/user`, // URL สำหรับดึงข้อมูลผู้ใช้งาน
    },
  }),
  actions: {
    // ฟังก์ชันสำหรับดึงข้อมูลจาก API
    async getData() {
      try {
        const res = await axios.get(this.material_url.getmaterial); // ทำการเรียก API เพื่อดึงข้อมูล
        // ตรวจสอบสถานะการตอบกลับจาก API
        if (res.status == 200) {
          return res;
        } else {
          return false; // คืนค่าเป็น false หากไม่ตรงตามเงื่อนไข
        }
      } catch (error) {
        // จัดการกับข้อผิดพลาดที่เกิดขึ้น
        if (error.response && error.response.status == 401) {
          window.open("/login", "_self"); // เปิดหน้า login หากได้รับสถานะ 401 (Unauthorized)
        }
      }
    },
  },
});
