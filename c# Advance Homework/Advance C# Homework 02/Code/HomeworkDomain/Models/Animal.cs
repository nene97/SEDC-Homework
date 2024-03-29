

using HomeworkDomain.Interfaces;

namespace HomeworkDomain.Models
{
    public abstract class Animal : IAnimal
    {
        public string TypeOfAnimal { get; set; }
        public int AgeOfAnimal { get; set; }
        public string LandOrSeaAir { get; set; }

        public Animal(string typeOfAnimal, int age, string landSeaAir)
        {
            TypeOfAnimal = typeOfAnimal;
            AgeOfAnimal = age;
            LandOrSeaAir = landSeaAir;

        }
        public abstract void PrintAnimal();
       
    }
}
