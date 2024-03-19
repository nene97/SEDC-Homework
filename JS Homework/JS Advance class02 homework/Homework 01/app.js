let colorInput = document.getElementById("color")
let sizeInput = document.getElementById("size")
let textInput = document.getElementById("text")
let btnInput = document.getElementById("btn")
let message = document.getElementsByTagName("p")



btn.addEventListener("click" , function(e){

    let color = colorInput.value;
    let size = sizeInput.value + "px";
    let text = textInput.value;
    let database = text.split(",");

    if(!sizeInput.value || !textInput.value || isNaN(sizeInput.value)){
       return "Enter valid info"
    }

    let unorderedList =  document.createElement("ul")
    unorderedList.style.color = color
    unorderedList.style.fontSize = size
    for(let i = 0; i < database.length ; i++){
        let listItem = document.createElement("li")
        listItem.innerText = database[i]
        unorderedList.appendChild(listItem)

    }
    e.target.parentNode.appendChild(unorderedList)
    sizeInput.value = ""
    textInput.value = ""

})