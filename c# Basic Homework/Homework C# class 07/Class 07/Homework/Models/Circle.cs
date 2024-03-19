

namespace Homework.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void getArea()
        {
            Console.WriteLine("The area of the rectangele is: " + 3.14 * (Radius * Radius));
        }

        public override void getPerimeter()
        {
            Console.WriteLine("The perimerat of the circle  is: " + 2 * 3.14 * Radius  );
        }
    }
}
