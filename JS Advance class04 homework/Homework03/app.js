let btn = document.getElementById("btn")
let result = document.getElementById("result")

function printStatsofPlanet(resultElement, data){
    let resultTable = resultElement.getElementsByTagName("tbody")[0]
    resultTable.innerHTML = ""
    for(let stats of data){ //there are only 10 planets otherwise i would use for loop with i < 10
        resultTable.innerHTML += `
        <tr style = "border : 1px solid">
            <td style = "border : 1px solid">Planet Name :</td>
            <td style = "border : 1px solid"> ${stats.name} </td>
        </tr>
        <tr style = "border : 1px solid">
            <td style = "border : 1px solid">Population :</td>
            <td style = "border : 1px solid"> ${stats.population} </td>
        </tr>
        <tr>
            <td style = "border : 1px solid">Climate :</td>
            <td style = "border : 1px solid"> ${stats.climate} </td>
        </tr>
        <tr style = "border : 1px solid">
            <td style = "border : 1px solid">Gravity</td>
            <td style = "border : 1px solid"> ${stats.gravity} </td>
        </tr>
        <br>
        `
    }
}

btn.addEventListener("click", function(e){
    e.preventDefault()
    fetch("https://swapi.dev/api/planets/?page=1")
    .then(function(response){
        response
        .json()
        .then(function(data){
            printStatsofPlanet(result , data.results)

        })
        .catch(function(error){
            console.log("error")
        })
    })
    .catch(function(error){
        console.log("error")
    })
})
