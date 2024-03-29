
using HomeworkDomain.Models;

Dog dogOne = new Dog("Dog", 3, "Land", "German Sheppard");
Dog dogTwo = new Dog("Dog",4 ,"Land" , "Husky");

Cat cat = new Cat("Cat",7 , "Land" , true);
Cat catTwo = new Cat("Cat" , 2 ,"Land" , false);

dogOne.PrintAnimal();
dogTwo.PrintAnimal();
cat.PrintAnimal();
catTwo.PrintAnimal();

dogOne.Bark();
dogTwo.Bark();

cat.Eat("Fish");
catTwo.Eat("Beef");


