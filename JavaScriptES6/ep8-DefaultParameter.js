//Default Parameter

getDataCustomer = (customerName, customerAddress="Bangkok") => { //ระบุ default ด้วย = ได้เลย
  //   if (!customerAddress) {
  //     customerAddress = "Bangkok";
  //   }
  const address = `ชื่อลูกค้า: ${customerName}
    ที่อยู่: ${customerAddress}`;
  return address;
};

console.log(getDataCustomer("Chinnawat", "Nongkhai"));
console.log(getDataCustomer("John")); //ไม่ได้ระบุที่อยู่
