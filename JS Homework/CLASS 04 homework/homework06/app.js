let firstArr = ["Nebojsha" , "Milan", "Ilin" , "Angel" ]
let lastArr = ["Velkovski", "Trpchevski" , "Trpchevski" , "Zafirovski"]

function merge(fullName, names){
    let i = 0;
   let  value = 0;
   let newArr = " "
    while(i < firstArr.length){

        value++


       newArr += value + " " + fullName[i] + " " + names[i] + "\n"

       console.log(value+ " " + fullName[i] + " " + names[i])

        i++

    }     return newArr


}
let news = merge(firstArr,lastArr)
console.log(news)