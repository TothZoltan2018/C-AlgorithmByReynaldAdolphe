using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dinners = { "Pasta", "Apple Pie", "Tuna Melt", "Mushroom Omlete", "Duck", "Eggplant" };

            Console.WriteLine("\n\nContent of the array:");
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\n\nContent of the Sorted array:");
            Array.Sort(dinners);            
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine($"\nBinary search for 'Beet Salad'");
            int index = Array.BinarySearch(dinners, "Beet Salad");
            DisplayWhere(dinners, index);

            Console.WriteLine($"\nBinary search for 'Tuna Melt'");
            index = Array.BinarySearch(dinners, "Tuna Melt");
            DisplayWhere(dinners, index);


            Console.ReadLine();
        }

        //private static void DisplayWhere(string[] dinners, int index)
        private static void DisplayWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index; //bitwise complement. See definition of BinarySearch (F12)
                Console.Write("Not found. Sorts between: ");

                if (index == 0)
                    Console.Write("beginning of array and ");
                else
                    Console.Write($"{array[index - 1]} and ");

                if (index == array.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine($"{array[index]}.");
            }
            else
                Console.WriteLine($"Found at index {index}.");
        }
    }
}
