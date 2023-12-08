



function celToFar(cel){
    let calculator = parseFloat(cel) * 1.8 + 32;
    console.log("Celsius to Fahrenheit :", calculator);
  
}

celToFar(85)



// in this solution i use the promp for user input in order to calculate 

function farTocel(far){
    let calculatorFar = (5/9) *(parseFloat(far) - 32) ;
    console.log("Fahrenheit to Celsius  :", calculatorFar);
  
}

let fahrPrompt = prompt("Fahrenheit:");
farTocel(fahrPrompt)


// Solution three 
// used two funciton and call on them .
// couldn't make it work with.toLowerCase()

function farhToCel(celsius){
    let result = celsius * 1.8 + 32;
    return result;

}
function celToFarh(fahrenheit){
    let result = (5/9) * (fahrenheit - 32);
    return result
}

let personChoice = prompt(" What do you want to convert F or C")
let personImput = parseFloat(prompt("Please enter value"))
if(personChoice === "F" || personChoice === "f"){
    console.log(`${celToFarh(personImput)}C`)

}else if (personChoice === "C" || personChoice === "c"){
    console.log(`${farhToCel(personImput)}F`)
}else {
    console.log("error")
};
