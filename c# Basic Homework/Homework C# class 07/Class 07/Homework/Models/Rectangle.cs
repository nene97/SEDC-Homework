
namespace Homework.Models
{
    public class Rectangle : Shape
    {
        public int SideA {  get; set; } 
        public int SideB { get; set; }  


        public override void getArea()
        {
            Console.WriteLine("The area of the rectangele is: " +  SideA * SideB);
        }

        public override void getPerimeter()
        {
            Console.WriteLine("The perimerat of the rectangle is: " + (SideA + SideB) * 2);
        }
    }
}
