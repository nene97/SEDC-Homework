function tellStory(name, mood, activity){
    let story = `This is ${name} . ${name} is a nice person. Today they are ${mood}. They are ${activity} all day. The end`
    console.log(story)
    return story

}
let fullStory = tellStory("Nebojsha" , "Happy" , "Smiling")
console.log(fullStory)



// example 2*****

let storyArray = ["Nebojsha" , "Happy" , "Smiling"]

function tellStoryOne(name, mood, activity){
    let storyOne = `This is ${storyArray[0]} . ${storyArray[0]} is a nice person. Today they are ${storyArray[1]}. They are ${storyArray[2]} all day. The end`
    console.log(storyOne)
    return storyOne
}
tellStoryOne(storyArray)

