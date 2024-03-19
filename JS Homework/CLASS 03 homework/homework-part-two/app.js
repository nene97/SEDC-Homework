
function dogAgeHumanAge(age){
    let conversionDogAge = parseFloat(age) * 7;
    let messageDogAge = `Your dog is ${conversionDogAge} years old`;
   console.log(messageDogAge);
   return messageDogAge;


}

let display = dogAgeHumanAge(26);
document.write(display);

dogAgeHumanAge(38);




// bonus same function for converting dog years to human
// i did it with prompts so the user can enter data

function coverter(humanAgeP, dogsYearsP){
    let calculDog = parseFloat(humanAgeP) * 7;
    console.log("Your dog would be ",calculDog, "years old in dogs years",)
    let calculHuman = parseFloat(dogsYearsP) / 7;
    console.log("You would be ", calculHuman,"in human years");


}


let humanAgePOne = prompt('Enter your dogs age');
let dogsYaersPrompt = prompt('Enter years in dog time:');
coverter(humanAgePOne, dogsYaersPrompt );
