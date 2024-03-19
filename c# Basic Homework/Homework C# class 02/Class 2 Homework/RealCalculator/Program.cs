Console.WriteLine("Enter the first number: ");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Operation:  ");
string opertion = Console.ReadLine();
Console.WriteLine("Enter the Second number: ");
int numTwo = int.Parse(Console.ReadLine());

var result = 0 ;

    if(opertion == "+")
{
    result = numOne + numTwo;
}
    else if(opertion == "-")
{
    result= numOne - numTwo;
}
    else if (opertion == "*")
{
    result = numOne * numTwo;
}
    else if (opertion == "/")0
{
    result= numOne / numTwo;
}
    else
{
    Console.WriteLine("Enter valid sign...");
}
    Console.WriteLine("The result is: " + result);