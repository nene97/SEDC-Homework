

let numsArr = [10, 20, 35, 55, 60 , 70];
let mainDiv = document.getElementById("main");

mainDiv.innerHTML += "<h1><b>The sum of all numbers in the list</b></h1>";

//the first function is to list the numbers and also to sum them up


function listOfall(sumArr, element ) {
  let sum = 0
  element.innerHTML += "<ul>";
  for (let i = 0; i < sumArr.length; i++) {
    element.innerHTML += `<li> ${sumArr[i]}<br><br></li>`; 
    sum += sumArr[i];
  }
  element.innerHTML += sum;
  element.innerHTML += "</br></ul>";
  
}

listOfall(numsArr, mainDiv);



// new function to sum the listed numbers with equasion


function sumOfAll(sumArr, element) {
  let sum = 0;
  for (let i = 0; i < sumArr.length; i++) {
  if(i === sumArr.length - 1){
    element.innerHTML += sumArr[i] + " ="
  }
  else{
    element.innerHTML += sumArr[i] + "+"
  }
  sum += sumArr[i]
  }
element.innerHTML += sum
}

sumOfAll(numsArr, mainDiv);
