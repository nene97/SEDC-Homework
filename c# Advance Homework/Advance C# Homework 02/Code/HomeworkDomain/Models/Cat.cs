

using HomeworkDomain.Interfaces;

namespace HomeworkDomain.Models
{
    public class Cat : Animal, ICat
    {
        public bool IsPlayful { get; set; }
        public Cat(string typeOfAnimal, int age, string landSeaAir, bool isPlayful) : base(typeOfAnimal, age, landSeaAir)
        {
            IsPlayful = isPlayful;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The cat loves to eat {food}");
        }

        public override void PrintAnimal()
        {
            if (IsPlayful) 
            {
                Console.WriteLine($"the {TypeOfAnimal} loves to play ");
            }
            else 
            {
                Console.WriteLine($"the {TypeOfAnimal} hates to play ");
            }
        }

        public void eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
