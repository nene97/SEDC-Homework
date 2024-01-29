function Product(name , category , discount , price){
    this.name = name
    this.category = category
    this.discount = discount
    this.price = price 
}

let products = [
    new Product("Coffe", "beverage", true , 37),
    new Product("Fanta", "beverage", false , 17),
    new Product("Jagermeister", "beverage", true , 70),
    new Product("Bread", "food", false , 56),
    new Product("Phone", "it", false , 1190),
    new Product("Tv", "it", true , 999),
    new Product("Cake", "food", false , 43),
    new Product("Beer", "beverage", true , 21),
    new Product("rice", "food", true , 90),
    new Product("pumpkin seeds", "food" ,true , 15),
    new Product("Cola", "beverage", true , 13),
    new Product("IceCream", "food", false , 22),
    new Product("eclair", "food" ,false , 4),
    new Product("Apple", "food", false , 87),
    new Product("aperol", "beverage" ,false , 19),
]

function hasDiscount(products){
    if(!products.discount){
        console.log("No")
    }else{
        console.log("Yes")
    }
}
// Find all products with price greater than 20.

let priceGreater = products.filter(p => p.price > 20).map(p => `Products with price greater than 20 :  ${p.name} with price : ${p.price}` )
console.log(priceGreater)

// Get the names of all products of Category Food, that are on discount.

let foodsOnDiscout = products.filter(p => {
    return p.category === "food" && p.discount === true
}).map(p => `All products of Category Food, that are on discount : ${p.name} `)

console.log(foodsOnDiscout)


// Get the price of all products that are on discount.

function checkPriceOnDiscount(prod){
    if(prod.discount === true){
        console.log(`Price of all products that are on discount : ${prod.name}  price: ${prod.price}`)
        
    }
    return
}


let priceOnDiscount = products.filter(checkPriceOnDiscount)




// Find the name and price of all products with name starting with a vowel, that are not on discount.





function checkPriceNotOnDiscount(prod){
    if(!prod.discount && prod.name[0].toUpperCase() === "A" || prod.name[0].toUpperCase()  === "I" || prod.name[0].toUpperCase()  === "E" ){
        console.log(`Price of all products that are not a on discount : ${prod.name}  price: ${prod.price}`)
        
    }
    return
}

let priceNotOnDiscount = products.filter(checkPriceNotOnDiscount)























