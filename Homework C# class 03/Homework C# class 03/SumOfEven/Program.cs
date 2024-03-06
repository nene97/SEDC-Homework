

int[] arraysOfInt = new int[] {4 , 3 , 7 , 3 , 2 , 8};


int sum = 0;
int sumTwo = 0;


foreach (int even in arraysOfInt)
{
    if (even % 2 == 0)
    {
        Console.WriteLine(even);
        sum = sum + even;
    }
}
Console.WriteLine(sum);



