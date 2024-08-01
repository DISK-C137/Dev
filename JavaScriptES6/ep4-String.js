//ทำงานกับ String

//multiline
const address = `ชื่อลูกค้า: เด็กชายก้อง 
ที่อยู่ 555/100 ถนนเฮฮา อำเภอเมือง จังหวัดเรียนดี 
เบอร์ติดต่อ: 0934571142`

//interpolation
let costomerName = "เด็กชายโจโจ้"
let CustomerAddress = "555/100 ถนนเฮฮา อำเภอเมือง จังหวัดเรียนดี"
let tell = "0807643060"

const address2 = `ชื่อลูกค้า: ${costomerName} 
ที่อยู่: ${CustomerAddress}  
เบอร์ติดต่อ: ${tell}`

console.log(address2)