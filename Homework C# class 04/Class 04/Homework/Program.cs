//Take one string from the input and print its last 5 characters.

Console.WriteLine("Write a few words !");
string input = Console.ReadLine();
string lastFiveChar = input.Substring(input.Length - 5);
Console.WriteLine(lastFiveChar);


//Take a sentence as input and print its words.

Console.WriteLine("Write a sentance!");
string sentance  = Console.ReadLine();

string[] words = sentance.Split(" ");

foreach(string word in words)
{
    Console.WriteLine(word);
}


//Create a function that takes a number as input. This method should return the sum of the digits in the number.

Console.WriteLine("Input a number ");
string inputNumber = Console.ReadLine();

int SumOfDigits(string number)
{

    string[] numberArray = new string[number.Length]; // new array for the splited number input 
    int counter = 0;
    int sum = 0;

    for (int i = 0; i < number.Length; i++)
    {
        numberArray[i] = number.Substring(counter , 1);
        counter++;
    }

    for (int i = 0; i < numberArray.Length; i++) 
    {
        bool success = int.TryParse(numberArray[i], out int parsedNumber);
        if (success) 
        {
            sum += parsedNumber;    
        }
        else
        {
            Console.WriteLine("Error");
        }

    }

    return sum; 


}

int result = SumOfDigits(inputNumber);
Console.WriteLine("The sum is " + result);
