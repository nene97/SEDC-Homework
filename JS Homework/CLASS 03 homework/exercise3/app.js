function calculateAge(birthYear, currentYear){
    let age = parseFloat(currentYear) - parseFloat(birthYear);
    console.log("You are ", age ,"years old")

}

calculateAge(1997, 2023)
calculateAge(1994, 2023)
calculateAge(1956, 2023)


// in this solution you only need to enter your birth year ...

function calculateAgeOne(birthYear){
    let ageTwo = new Date().getFullYear() -  parseFloat(birthYear) ;
    console.log("You are ", ageTwo ,"years old")
    let ageMessage = `You are ${ageTwo} years old`
    return ageMessage

}

calculateAgeOne(1997)
calculateAgeOne(1994)
calculateAgeOne(1956)
calculateAgeOne(1923)

// still struggling naming the variables :)
let ageOne = calculateAgeOne(1997)
document.write(ageOne)


let ageThree = calculateAgeOne(2005)
document.write(ageThree)