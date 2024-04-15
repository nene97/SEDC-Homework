

using Homework07.Domain.Models;

namespace Homework07
{
    public static class Helper 
    {

        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine($"Printing {list.Count} items");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }


        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine($"Printing {list.Count} items");

            foreach (T item in list)
            {
                item.PrintInfo();
            }
        }

        public static void PrintInfoOrigin<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine($"Printing {list.Count} items");

            foreach (T item in list)
            {
                item.PrintInfo2();
            }
        }


    }
}
