<template>
  <ul>
    <Person
      v-for="item in employees"
      :id="item.id"
      :key="item.id"
      :name="item.name"
      :salary="item.salary"
      :department="item.department"
      :isVisible="item.isVisible"
      @show="toggleVisible"
      @delete="removeEmp"
    />
  </ul>
</template>

<script>
import Person from "./Person.vue";
export default {
  name: "ListData",
  components: {
    Person,
  },
  data() {
    return {
      employees: [
        { id:1, name: "ก้อง รักสยาม", salary: 40000, department:"โปรแกรมเมอร์",isVisible:false},
        { id:2, name: "แก้ม เรียนดี", salary: 30000, department:"ฝ่ายการตลาด",isVisible:false},
        { id:3, name: "โตโต้ ขยันทำงาน", salary: 900, department:"โปรแกรมเมอร์",isVisible:false},
        { id:4, name: "สมปอง ยิ้มเก่ง", department:"กราฟฟิก",isVisible:false},
        { id:5, name: "ตั๊กแตน เรียนดี", department:"ฝ่ายขาย",isVisible:false},
      ],
    };
  },
  methods:{
    toggleVisible(id){
      this.employees = this.employees.map((item)=>{
        if(item.id === id){
          return {...item,isVisible:!item.isVisible}
        }
        return item
      })
    },
    removeEmp(id){
      this.employees = this.employees.filter((item)=>{
        return item.id !== id
      })
    }
  }
};
</script>

<style scoped>
ul{
    list-style: none;
    margin: 1rem 0;
    padding: 0;
}
</style>
