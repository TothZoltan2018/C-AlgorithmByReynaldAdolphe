using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 42;
            int[] array = new int[] { 11, 42, 42, 42, 57, 58, 62, 78 }; //SORTED array
            Console.WriteLine("Our array contains:");
            Array.ForEach(array, x => Console.WriteLine(x + " "));

            Console.WriteLine($"\n\nThe result of the binary search for {theValue} is: ");
            Console.WriteLine(BinarySearch(array, theValue));

            Console.ReadLine();
        }


        /// <summary>
        /// a: array
        /// x: what we are searching for
        /// p: first index
        /// q: midpoint index
        /// r: last index
        /// </summary>
        /// <param name="a">: array</param>
        /// <param name="x">: what we are searching for</param>
        /// <returns></returns>
        public static int BinarySearch(int[] a, int x)
        {
            //Step 1 - Initalize variables
            int p = 0;
            int r = a.Length - 1;

            //Step 2 - Searching
            while (p <= r)                //When true, we are still in the range
            {
                int q = (p + r) / 2;      //Find the midpoint
                if (x < a[q])             //Our searched value is smaller then the one in the midpoint
                    r = q - 1;            //We narowed the array to search in to the left half (smaller values)

                else if (x > a[q])
                    p = q + 1;            //We narowed the array to search in to the right half (larger values)
                else
                    return q;             //Not smaller and not larger --> It is that
            }

            //Step 3 - Inidacte not found
            return -1;
        }
    }
}
