

namespace Homework.Models
{
    public class Shape
    {
        string _name;
            public string Name
        {
            get
            { return _name; }
            set
            {
                if (value.Length > 1)
                {
                    _name = value;  
                }
                else
                {
                    _name = "Enter a valid name";
                }
            }
        }
        string _color;
        public string Color
        {
            get
            { return _color; }
            set
            {
                if (value.Length > 1) //some form of validation
                {
                    _color = value;
                }
                else
                {
                    _color = "Enter a valid color";
                }
            }
        }
        public int[] Position { get; set; }

        public virtual void getArea()
        {
            Console.WriteLine("there is no special implementation for area");
        }

        public virtual void getPerimeter()
        {
            Console.WriteLine("there is no special implementation for perimeter ");
        }

        public int[] Move() // ne mi bese malku jasno baranjeto 
        {
            int[] result = Position ;
            for (int i = 0; i < Position.Length; i++) 
            {
                result[i] = Position[i] + 5;

                Console.WriteLine("Updatet pos :" + Position[i]);

            }

            return Position;
            
        }


    }
}
