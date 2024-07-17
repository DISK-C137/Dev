<!-- ส่วนการแสดงผล -->
<template>
  <div>
    <FormComponent/>
    <ListData />

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
  }
}
</script>