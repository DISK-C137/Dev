//Rest Parameter
//เอาไว้เพิ่ม parameter ด้วย ... เป็น array แบบไม่จำกัด

summation = (...numberArr) => {
    let total = 0
    for(let number of numberArr) total += number
    return total
}

console.log(summation(50,100,150))
console.log(summation(50,100,150,200))