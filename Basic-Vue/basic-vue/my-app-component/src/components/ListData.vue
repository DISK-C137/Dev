<template>
    <div>
        <Person name="ก้อง" salary=30000 />
        <Person name="โจโจ้" salary=20000 />
        <Person name="ตัํกแตน" salary=15000 />
        <Person name="แก้ม" salary=18000 />
    </div>
</template>

<script>
import Person from './Person.vue'
export default {
    name:"ListData",
    components:{
        Person
    },
}
</script>

<style>

</style>