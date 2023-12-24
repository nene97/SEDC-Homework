
// the first solution is with valdiation of book title

// let books = {
//     title:"The Robots of dawn",
//     author:"Isaac Asimov",
//     statusReading:true,
//     check: function(booktitle){
//         if(this.title === booktitle){
//             console.log(`you have read ${this.title} by ${this.author}`)
//         }else(console.log("nope"))
//     }
// }

// books.check("The Robots of dawn")


// solution two

// function Books(title,author,readingStatus){
//     this.title = title
//     this.author = author
//     this.readingStatus = readingStatus
//     this.done = function(){
//         if(this.readingStatus){
//             let stts = `You have read ${title} by ${author}`
//             return stts
        
//         } else {
//             let sttsOne = `You still need to read ${title} by ${author}`
//             return sttsOne
        
//         }
//     }
// }

//  let title = prompt("Enter book name :")
//  let author = prompt("Enter author :")
// let readingStatusInput = prompt("Have you read this book? (true/false)")
// let readingStatus = readingStatusInput.toLowerCase() === "true"
// //creating new instance from the Books constructor function
// let book = new Books (title , author , readingStatus)
//  console.log(book.done())



//  same solution vith set variables

// let isItRead = new Books ("The Robots of dawn" , "Isaac Asimov", true)
// console.log(isItRead.done())

// let isItReadTwo = new Books ("Mockingjay: The Final Book of The Hunger Games" , "Mockingjay: The Final Book of The Hunger Games" , false)
// console.log(isItReadTwo.done())




//solution three with inputs

let inputs = document.getElementsByTagName("input")
let titleInptu = inputs[0]
let authorInput = inputs[1]
let statusOf = inputs[2]
let checkButton = document.getElementById("check")
let result = document.getElementById("result")
let err = document.getElementById("err")
let bookDataBase = []
// constructor 

function Books(title,author,readingStatus){
         this.title = title
         this.author = author
         this.readingStatus = readingStatus

}

function printBooks(element , books ){
    element.innerHTML = ""
    for(let i = 0; i < books.length; i++){
        element.innerHTML += `
        <p>You have read ${books[i].title} by ${books[i].author}
        <hr></p>`
    }
}


checkButton.addEventListener("click" , function(e){
    e.preventDefault() 
    if(titleInptu.value === "" || authorInput.value === "" || statusOf.value === "" ){
        err.innerText = "Invalid"
        return
    }
    if(statusOf.value === "false"){
        err.innerText = `You havent read this book yet`
        return
    }
    let book = new Books (titleInptu.value , authorInput.value, statusOf.value)
    bookDataBase.push(book)
    result.innerHTML = ""
    err.innerText = ""
    printBooks(result , bookDataBase )
    titleInptu.value = ""
    authorInput.value = ""
    statusOf.value = ""
   



})
















