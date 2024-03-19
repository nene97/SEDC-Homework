function atmCash(amount = "Please enter amount") {
  let accountAmount = 10000;
  if (amount <= accountAmount) {
    console.log(
      "You withdrawn",
      amount,
      "$",
      "you have",
      accountAmount - amount,
      "left"
    );
  } else if (amount > accountAmount) {
    console.log("NOt enough money");
  }
}

let promotatmCash = parseFloat(
  prompt("Please enter the amount you would like to withdraw:")
);
atmCash(promotatmCash);


// second solution 

function atm(withdraw){
    let amount = 15000;
    if(withdraw <= amount){
        withdrawMessage = `You withdrawn ${parseFloat(withdraw)} You have ${amount - parseFloat(withdraw)} left `
        console.log(withdrawMessage)
        return withdrawMessage
    }else if(withdraw > amount){
        withdrawMessageOne = `Not enough money`
        console.log(withdrawMessageOne)
        return withdrawMessageOne
    }
}

let promptOne = parseFloat(prompt("Enter amount :"))
atm(promptOne)
