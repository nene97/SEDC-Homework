using System.Collections;

//arrays

Console.WriteLine("========ARRAYS============");

int[] intArray = new int[3];//allocate memory for 3 ints

string[] stringArray = new string[] { "Hello", "Bye" };

foreach (string str in stringArray)
{
    Console.WriteLine(str);
}

//array list
Console.WriteLine("==========ARRAYS LIST============");

//array list accepts all types can have mixed array lists nema odreden broj na elementi
ArrayList arrayList = new ArrayList();//empty array list

ArrayList secondArrayList = new ArrayList { "Hello", 5, true };
secondArrayList.Add("Bye");
secondArrayList.Remove("Hello");//we send a value to be removed
secondArrayList.RemoveAt(1);//we send an index to be removed

foreach (var item in secondArrayList)// we use var because it changes its type na sekoja iteracija ke ima dr vrednost(data type)
{
    Console.WriteLine(item.GetType());// we can see the types
}


for (int i = 0; i < secondArrayList.Count; i++)//Count => numbe rof elements
{
    Console.WriteLine(i.ToString() + secondArrayList[i]);
}


Console.WriteLine("========== LIST ============");

//lists must have all emements as a samne type with no number constrains
List<int> emptyListOfInts = new List<int>();
List<string> emptyListOfStrings = new List<string>();
List<int> listOfInts = new List<int> { 2, 88, 9 };
listOfInts.Add(5);
listOfInts.Add(-10);
listOfInts.Remove(88);
listOfInts.RemoveAt(0);
Console.WriteLine(listOfInts[0]);
Console.WriteLine($"number of elements in list of ints: {listOfInts.Count}");

foreach (int number in listOfInts)
{
    Console.WriteLine(number);
}

Console.WriteLine("========== DICTIONARY  ============");
//key value pairs


Dictionary<int, string> products = new Dictionary<int, string>()//we dont have index  we use the key
{
    {111 , "Patotoe"},
    {222, "Milk"},
    {333 , "Bread"}
};

Console.WriteLine(products[222]); // we use the key like we use the index

products.Add(444, "Tea");
products[111] = "Coffe"; //we change the value
Console.WriteLine(products[111]);

bool keyExists = products.ContainsKey(222);
Console.WriteLine(keyExists);
products.Remove(333);
foreach (var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


