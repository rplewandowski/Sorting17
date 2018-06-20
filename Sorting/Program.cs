using Sorting.DAL;
using Sorting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] col = Data.GetData(10);

            Console.Write("Source array: ");
            foreach (var item in col)
            {
                Console.Write(item);
            }

            int[] bubbleSorted = Methods.BubbleSort(col);
            Console.WriteLine("");
            Console.Write("BubbleSorted array: ");
            foreach (var item in bubbleSorted)
            {
                Console.Write(item);
            }

            int[] insertionSorted = Methods.InsertionSort(col);
            Console.WriteLine("");
            Console.Write("Sorted by insertion array: ");
            foreach (var item in insertionSorted)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
