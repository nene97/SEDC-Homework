let btn = document.getElementById("btn");
let result = document.getElementById("result");
let resList = document.getElementById("list")




btn.addEventListener("click", function (e) {
  e.preventDefault();
  fetch("http://api.open-notify.org/astros.json")
    .then(function (response) {
      response
        .json()
        .then(function (data) {
        for(let people of data.people){
            let li = document.createElement("li")
            li.innerText = `
            Astronaut name : ${people.name}
            On board : ${people.craft}
            `
            resList.appendChild(li)
        }
        })
        .catch(function (error) {
          console.log("error");
        });
    })
    .catch(function (error) {
      console.log("error");
    });
});
