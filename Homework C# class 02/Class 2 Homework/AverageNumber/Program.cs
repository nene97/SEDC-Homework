Console.WriteLine("Enter the first number : ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number : ");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number : ");
int numberThree = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the fourth number : ");
int numberFour = int.Parse(Console.ReadLine());

int result;
    result = numberOne + numberTwo + numberThree + numberFour;
int average = result / 4;
Console.WriteLine($"The average of : {numberOne} , {numberTwo} , {numberThree} , {numberFour} is: " + average);
