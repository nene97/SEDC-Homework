

namespace Homework07.Domain.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public double MilesPerGalon { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// Acceleration time to 100kmph
        /// </summary>
        public double AccelerationTime { get; set; }
        public string Origin { get; set; }

       

        public override void PrintInfo()
        {
            Console.WriteLine($" the model is {Model} miles per galon : {MilesPerGalon} with  {Cylinders} cylinder, horse power  {HorsePower} its made in {Origin} ");
        }

        public override void PrintInfo2()
        {
            Console.WriteLine($" Made in  {Origin} ");
        }

        

    }

        
}
