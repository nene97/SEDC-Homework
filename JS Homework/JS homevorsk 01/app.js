
// this is a fixed calculation  with 5%
let priceOfPhone = 119.95;
let taxRate = 5 / 100 * priceOfPhone;
let amountOfPhones = 30;
let totalPrice = (priceOfPhone + taxRate ) * amountOfPhones;
console.log(totalPrice)


// in this solution you can change the %
let priceOfPhoneOne = 119.95;
let percentage = 5;
let percentVal = priceOfPhoneOne * (percentage / 100);
let amountOfPhonesOne  = 30;
let totalPriceOne = (priceOfPhoneOne + percentVal) * amountOfPhonesOne;
console.log(totalPriceOne);

