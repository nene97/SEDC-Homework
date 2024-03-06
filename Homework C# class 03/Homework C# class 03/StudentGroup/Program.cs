string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] {"Bojan" , "Doris" ,"Nebojsha" };

Console.WriteLine("Enter a number between 1 and 2 to print the groups ! ");

bool number = int.TryParse(Console.ReadLine(), out int groupNumber);



if(number)
{
    if(groupNumber == 1)
    {
        Console.WriteLine("The Students in G1 are: ");
        for(int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }
    if(groupNumber == 2) 
    {
        Console.WriteLine("The Students in G2 are: ");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
}
else
{
    Console.WriteLine("Wrong input !!");
}