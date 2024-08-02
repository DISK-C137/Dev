//Destructuring การสลายโครงสร้าง
//คือ การแยกค่าที่อยู่ใน array หรือ object ให้จับคู่กับตัวแปร

//การทำงานกับ array------------------------------------------------------------
const colors = ["เขียว","แดง","เหลือง"]
//const [green,red,yellow] = colors
const [green,,yellow] = colors

console.log("🚀 ~ green:", green)
//console.log("🚀 ~ red:", red)
console.log("🚀 ~ yellow:", yellow)

//การทำงานกับ object------------------------------------------------------------
const product = {
    productName: "คอมพิวเตอร์",
    price:30000,
    stock:10
}
const {productName,price,stock} = product
console.log(productName)
console.log(price)
console.log(stock)







