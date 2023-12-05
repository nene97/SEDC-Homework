let userInput = prompt('What is your budget?');
console.log(userInput);

let parseUserInput = parseFloat(userInput);

if(parseUserInput <= 100){
    console.log('You are broke')
}else if(parseUserInput > 100 && parseUserInput <= 300){
    console.log('You can drink coffe in a nice coffe bar')

}else if (parseUserInput > 300 && parseUserInput <= 500){
    console.log('You can go out for drinks with fiends')

}else if(parseUserInput > 500 && parseUserInput <= 700){
    console.log('You can go out at a lounge bar for food and drinks')

}else if(parseUserInput > 700 && parseUserInput <= 1000){
    console.log('You can go out in a nice restaurant')

}else if(parseUserInput > 1000 && parseUserInput <= 3000 ){
    console.log('You can take your friends to lunch')
}else if(parseUserInput > 3000 ){
    console.log('You can do what ever you want')
}
else if (parseUserInput = null){
    console.log('Please input value')
}