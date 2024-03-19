//////Make a method called AgeCalculator
////The method will have one input parameter, your birthday date
////The method should return your age
////Show the age of a user after he inputs a date
////Note: take into consideration if the birthday is today, after or before today
using Task_01;

///
Console.WriteLine("Please enter your birthday date ");


Console.WriteLine("Enter your birth year e.g.. 29.12.1998 !");
string input  = Console.ReadLine(); 
DateTime dateTime = DateTime.Parse(input);

void AgeCalculator(DateTime birthdate)
{
    var result = DateTime.Now.Year - birthdate.Year;

    Console.WriteLine(result); //this is rounded to the full year not counting months and days

    int currentYear = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
    int birthYear = int.Parse(birthdate.ToString("yyyyMMdd"));
    int age = (currentYear - birthYear) / 10000; // gets a 6 digit number by dividing it by 10000 it removes  the last four and you get the year
    Console.WriteLine(age);     //this shows the right age taking in consideration the month and the day
}

AgeCalculator(dateTime);


Console.WriteLine("Enter a dog name: ");

string dogName = Console.ReadLine();    

Console.WriteLine("Enter a dog breed: ");

string dogBreed = Console.ReadLine();

Console.WriteLine("Enter the collor of the dog:");

string dogColor = Console.ReadLine();   

Dog dog = new Dog(dogName, dogBreed , dogColor);

Console.WriteLine($"the dog is :{dog.name} breed {dog.breed} and color {dog.color} ");

Console.WriteLine("Enter 1 for the dog to eat");
Console.WriteLine("Enter 2 for the dog to play");
Console.WriteLine("Enter 3 for the dog to chase its tail");

int options = int.Parse(Console.ReadLine());

if(options == 1)
{
    Console.WriteLine(dog.Eat());
}
else if(options == 2)
{
    Console.WriteLine(dog.Play());
}
else if(options == 3)
{
    Console.WriteLine(dog.ChaseTail());

}
else
{
    Console.WriteLine("Error");
}


