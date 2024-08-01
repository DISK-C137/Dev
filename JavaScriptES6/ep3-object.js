//ทำงานกับ object

//  ตัวแปรเก็บข้อมูล
const username = "Chinnawat"
const age = 27
const address = "NongKhai"

const customer = {
    customerName:username,
    age,
    address,
    showdata(){
        console.log(this.customerName)
    }
}

//console.log(customer)
customer.showdata()