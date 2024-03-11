

namespace Task_01
{
    public class Dog
    {
        public string name { get; set; }    
        public string breed { get; set; }
        public  string color { get; set; }  


        public Dog(string name , string breed , string color)
        {
            this.name = name;   
            this.breed = breed;
            this.color = color; 
        }   
        
        public string Eat()
        {
            string message = "The dog is now eating !!!";
            return message;
        }

        public string Play()
        {
            string message = "The dog is now playing !!!";
            return message;
        }
        public string ChaseTail()
        {
            string message = "The dog is now chasing its tail !!!";
            return message;
        }

    }
}
