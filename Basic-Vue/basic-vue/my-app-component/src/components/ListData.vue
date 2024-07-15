<template>
    <div>
        <h1>{{ message }}</h1>
        <Person />
        <Person />
    </div>
</template>

<script>
import Person from './Person.vue'
export default {
    name:"ListData",
    components:{
        Person
    },
    data(){
        return{
            message:"แสดงรายชื่อพนักงาน"
        }
    }
}
</script>

<style>

</style>