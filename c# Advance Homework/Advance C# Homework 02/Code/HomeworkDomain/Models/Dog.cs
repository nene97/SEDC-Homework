
using HomeworkDomain.Interfaces;

namespace HomeworkDomain.Models
{
    public class Dog : Animal, IDog
    {
        public string BreedOfDog { get; set; }

        public Dog(string typeOfAnimal, int age, string landSeaAir, string breed) : base(typeOfAnimal, age, landSeaAir)
        {
            BreedOfDog = breed;
        }
        
        

        
        public void Bark()
        {
            Console.WriteLine("The dog is barking!!!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The type is {TypeOfAnimal} ,{AgeOfAnimal} years old it is a {LandOrSeaAir} animal ,of the breed {BreedOfDog}");
        }
    }
}
