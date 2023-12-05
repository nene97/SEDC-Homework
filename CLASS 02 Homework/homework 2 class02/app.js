let birthyear = prompt('Please enter the year you were born in:');
let birthYearParse = parseFloat(birthyear);

let  zodiacNum = (birthYearParse - 4) % 12;
console.log(zodiacNum)
if(zodiacNum === 0 ){
    console.log('Your zodiac sign is RAT')
}else if(zodiacNum === 1){
    console.log('Your zodiac sign is OX ')
    alert('Your zodiac sign is OX')
}else if (zodiacNum === 2){
    console.log('Your zodiac sign is TIGER')
    alert('Your zodiac sign is TIGER')


}else if(zodiacNum === 3){
    console.log('Your zodiac sign is RABBIT ')
    alert('Your zodiac sign is RABBIT')


}else if(zodiacNum === 4){
    console.log('Your zodiac sign is DRAGON ')
    alert('Your zodiac sign is DRAGON')


}else if(zodiacNum === 5){
    console.log('Your zodiac sign is SNAKE')
    alert('Your zodiac sign is SNAKE')


}else if(zodiacNum === 6){
    console.log('Your zodiac sign is HORSE ')
    alert('Your zodiac sign is HORSE')


}else if(zodiacNum === 7){
    console.log('Your zodiac sign is GOAT ')
    alert('Your zodiac sign is GOAT ')


}else if(zodiacNum === 8){
    console.log('Your zodiac sign is MONKEY ')
    alert('Your zodiac sign is MONKEY')


}else if(zodiacNum === 9){
    console.log('Your zodiac sign is ROOSTER')
    alert('Your zodiac sign is ROOSTER ')


}else if(zodiacNum === 10){
    console.log('Your zodiac sign is DOG ')
    alert('Your zodiac sign is DOG ')


}else if(zodiacNum === 11){
    console.log('Your zodiac sign is PIG')
    alert('Your zodiac sign is PIG')
}else if(zodiacNum === isNaN || ' ' ){
    alert('Please write the year')
}
