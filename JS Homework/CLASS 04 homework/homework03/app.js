let stringArry = ["Hello", "there", "students", "of", "SEDC","!!"]

function stringConcatanation(stringCon){
    let i = 0;
    let newArray = "";
    while(i < stringCon.length ){
        conc = newArray += stringCon[i]
        result = stringCon.join()
        i++
    }return result
}
let singelString = stringConcatanation(stringArry)
console.log(singelString)