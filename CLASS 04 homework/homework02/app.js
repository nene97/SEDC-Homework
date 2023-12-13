let arrNum = [5, 15, 40 , 56, 66]

function sumOfNum(numbers){
    let newArray = 0
    for (let i = 0; i < numbers.length; i++) {
        newArray += numbers[i]
    } return newArray

}
let arrySum = sumOfNum(arrNum)
console.log(arrySum)


// with while loop

function newFun(filler){
    let inc = 0
    let newArrayOne = 0
    while(inc < filler.length){
        sumUp = newArrayOne += filler[inc]

        inc++
    }return sumUp

}
let sumOFall = newFun(arrNum)
console.log(sumOFall)
// alert(sumOFall)

