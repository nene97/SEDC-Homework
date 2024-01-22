let reminderTitleInput = document.getElementById("reminderTitle")
let textAreaInput= document.getElementById("textArea")
let priorityInput = document.getElementById("priority")
let colorInput = document.getElementById("color")
let addBtn = document.getElementById("add")
let showBtn = document.getElementById("show")


let arrOfRemind = []

function Adding(title, text, priority, color){
    this.title = !title ? "unnamed" : title;
    this.text = !text ? "no input" : text;
    this.priority = priority;
    this.color = color;
        if(this.title === "unnamed"){
            return "Please enter a title"
        }
        if(this.text === "no input"){
            return "Please describe the reminder"
        }
    

}


addBtn.addEventListener("click" , function(){
    let title = reminderTitleInput.value
    let text = textAreaInput.value
    let priority = priorityInput.value
    let color = colorInput.value
    
    let add = new Adding(title , text , priority , color)
    arrOfRemind.push(add)
    console.log(arrOfRemind)
    reminderTitleInput.value = ""
    textAreaInput.value = ""

})

console.log(arrOfRemind)


showBtn.addEventListener("click" , function(){

    let resultTable = document.getElementById("result")
    resultTable.style.border = "3px solid"
    let color = colorInput.value
    resultTable.innerHTML = ""
    for(let i = 0; i < arrOfRemind.length ; i++){
        resultTable.innerHTML += `
        <tr style = "border : 1px solid">
          <th  style="color: ${arrOfRemind[i].color}; border : 1px solid">${arrOfRemind[i].title}</th>
          <td style = "border : 1px solid">Priority: ${arrOfRemind[i].priority}</td>
          <td style = "border : 1px solid">Description: ${arrOfRemind[i].text}</td>
        </tr> 
        `
    }
    




})


console.log(arrOfRemind)