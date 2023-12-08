



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