//Spread Operator

const newArr = [100,200,300]
const data = [10,20,...newArr] //ใส่ ... หน้าตัวแปร เป็นการเพิ่มสมาชิกของ newArr เข้าไปใน data

console.log("🚀 ~ data length:", data.length)
console.log("🚀 ~ data:", data)

//หรือ

const colors = ["เขียว","น้ำเงิน","ขาว"]
const allColors = ["แดง","เหลือง",...colors]

const newColors = ["ดำ","เทา"]
allColors.push(...newColors)
console.log("🚀 ~ allColors:", allColors)

