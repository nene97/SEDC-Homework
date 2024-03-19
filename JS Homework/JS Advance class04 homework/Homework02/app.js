let academyTitle = document.getElementById("academyTitle");
let list = document.getElementById("list");
let resultDiv = document.getElementById("result");
let btn = document.getElementById("btn");

// btn.addEventListener("click",function(e){
//     e.preventDefault()
//     fetch("https://raw.githubusercontent.com/Drakso/AJS2019/master/Class1/students.json")
//     .then(function(response){
//         response
//         .json()
//         .then(function(data){
//             academyTitle.innerText = data.academy
//             for(let student of data.students){
//                 let li = document.createElement("li")
//                 li.innerText = `
//                 ${student}
//                 `
//                 list.appendChild(li)

//                 console.log(student)
//             }

//         })
//         .catch(function(error){
//             console.log("error")
//         })
//     })
//     .catch(function(error){
//         console.log("error")
//     })
// })




//solution 2 with 2 seperate functions

function callAcademy(resultElemet, academy) {
  resultElemet.innerText = academy;
}

function callStudents(resultElement, data) {
  for (let student of data) {
    let li = document.createElement("li");
    li.innerText = student;
    resultElement.appendChild(li);
  }
}

btn.addEventListener("click", function (e) {
  e.preventDefault();
  fetch(
    "https://raw.githubusercontent.com/Drakso/AJS2019/master/Class1/students.json"
  )
    .then(function (response) {
      response
        .json()
        .then(function (data) {
          callAcademy(academyTitle, data.academy);
          callStudents(list, data.students);
        })
        .catch(function (error) {
          console.log("error");
        });
    })
    .catch(function (error) {
      console.log("error");
    });
});
