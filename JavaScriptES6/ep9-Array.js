//ทำงานกับ Array

const data = [100,200,300]
console.log("🚀 ~ data:", data)

//join = แปลงเป็น string
const result = data.join("*") //ใส่เครื่องหมายคั่นเองได้ใน ()
console.log("🚀 ~ result:", result)

//concat = การต่อสมาชิกใน array
const data1 = [100,200,300]
const data2 = [400,500]

const allData = data1.concat(data2)
console.log("🚀 ~ allData:", allData)
