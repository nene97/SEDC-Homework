let button = document.getElementById("button");
let inputRowsMain = document.getElementById("inputRows")
  let inputColsMain = document.getElementById("inputCols")

button.addEventListener("click", function (event) {
  event.preventDefault();

  let tbl = document.createElement("table");
  let tblBody = document.createElement("tbody");
  let inputRows = Number(inputRowsMain.value)
  let inputCols = Number(inputColsMain.value)
  if(isNaN(inputRows) && isNaN(inputCols)){
    alert("Please enter valid numbers only")
    tbl = ""
  }
  if(!inputRows &&  !inputCols){
    alert("Please enter valid numbers only")
    tbl = ""
  }
  for (let i = 0; i < inputRows; i++) {
    let row = document.createElement("tr");
    for (let j = 0; j < inputCols; j++) {
      let cell = document.createElement("td");
      let cellText = document.createTextNode(
        `cell in row ${i + 1}, column ${j + 1}`
      );
      cell.appendChild(cellText);
      row.appendChild(cell);
    }
    tblBody.appendChild(row);
  }
  tbl.appendChild(tblBody);
  document.body.appendChild(tbl);
  tbl.setAttribute("border", "2");
});
