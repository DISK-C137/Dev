<template>
  <div>
    <h1>{{ message }}</h1>
  </div>
</template>

<script>
export default {
  name: "PersonData",
  data() {
    return {
      message: "แสดงข้อมูลพนักงาน",
    };
  },
};
</script>

<style scoped>
h1 {
  color: red;
}
</style>
