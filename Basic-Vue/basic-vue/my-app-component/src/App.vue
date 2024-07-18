<!-- ส่วนการแสดงผล -->
<template>
  <div>
    <FormComponent/>
    <ListData :employees="employees" />

  </div>
</template>

<!-- ส่วนควบคุมการทำงาน -->
<script>
import FormComponent from './components/FormComponent.vue' //เรียกใช้งาน Form component 
import ListData from './components/ListData.vue' //เรียกใช้งาน ListData component 

export default { //ส่งออกข้อมูล
  name:"App",
  components: { //ประกาศใช้ ListData component 
    ListData,
    FormComponent
  },
  data(){
    return{
      employees:[
        {name:"ก้อง",salary:40000},
        {name:"แก้ม",salary:30000},
        {name:"โจโจ้",salary:20000},
        {name:"สมปอง",salary:15000},
        {name:"ชาลี",salary:18000},
        {name:"ตุ๊กตา",salary:50000}
      ]
    }
  }
}
</script>