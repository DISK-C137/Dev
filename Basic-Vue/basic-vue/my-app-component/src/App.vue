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
        {name:"โตโต้",salary:900},
        {name:"สมปอง"},
        {name:"ตั๊กแตน"}
      ]
    }
  }
}
</script>