import { defineStore } from "pinia"; // นำเข้าโมดูล defineStore จาก Pinia สำหรับสร้าง Store
import axios from "axios"; // นำเข้า axios สำหรับการเรียก API
import moment from 'moment'; // นำเข้า moment สำหรับจัดการเวลา (แต่ในโค้ดนี้ moment ยังไม่ได้ถูกใช้งาน)

// กำหนดและสร้าง Store สำหรับจัดการข้อมูลผู้ใช้งาน
export const userStore = defineStore({
  id: "userStore", // กำหนด id ของ Store เป็น "userStore"
  state: () => ({
    material_url: {
      // URL สำหรับดึงข้อมูลผู้ใช้งานจาก API
      getmaterial: `https://66a6790223b29e17a1a2c205.mockapi.io/user`,
    },
  }),
  actions: {
    // ฟังก์ชันสำหรับดึงข้อมูลจาก API
    async getData() {
      try {
        // ทำการเรียก API เพื่อดึงข้อมูล
        const res = await axios.get(this.material_url.getmaterial);
        
        // คืนค่าผลลัพธ์จากการเรียก API
        return res;

        // ตรวจสอบสถานะการตอบกลับจาก API
        // ** Note: โค้ดด้านล่างนี้จะไม่มีการทำงานเนื่องจาก return ได้ถูกเรียกใช้ไปแล้ว **
        if (res.status == 200 && res.data.status === true) {
          // ทำการตรวจสอบเพิ่มเติมตามที่ต้องการ (ในที่นี้ยังไม่มีการทำอะไรเพิ่มเติม)
        } else {
          return false; // คืนค่าเป็น false หากไม่ตรงตามเงื่อนไข
        }
      } catch (error) {
        // จัดการกับข้อผิดพลาดที่เกิดขึ้น
        if (error.response && error.response.status == 401) {
          // เปิดหน้า login หากได้รับสถานะ 401 (Unauthorized)
          window.open("/login", "_self");
        }
      }
    },
  },
});
