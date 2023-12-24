let input = prompt("enter some words")

let animal = {
    nameOfDog:"Luna",
    kind:"Dog",
    speak: function(words){
        console.log(`The ${this.kind} is  ${this.nameOfDog}  and it says : ${words}`)
    }

}
animal.speak(input)