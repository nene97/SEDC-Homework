function logTodo(data){
    console.log(data[0].id)
    for(let users of data){
        if(users.id === 1){
            console.log(users.id)
            console.log(users.userId)
            console.log(users.title)
            console.log(users.completed)
            break
        }
    }
}






async function getToDo(){
    try{
        let response = await fetch("https://jsonplaceholder.typicode.com/todos")
        let parsedToDo = await response.json()
        logTodo(parsedToDo)
    }catch(errorResponse){
        console.log(errorResponse)
    }
}

getToDo()