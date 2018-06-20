using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Services
{

    public static class Methods
    {
        private static int[] CopyArray(int[] source)
        {
            int[] col = new int[source.Length];
            Array.Copy(source, col, source.Length);
            return col;
        }
        public static int[] BubbleSort(int[] source)
        {
            bool swapped = false;
            int temp = int.MinValue;
            int[] col = CopyArray(source);

            do
            {
                swapped = false;
                for (int i = 0; i < col.Count() - 1; i++)
                {
                    if (col[i] > col[i + 1])
                    {
                        temp = col[i + 1];
                        col[i + 1] = col[i];
                        col[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);




            return col;
        }

        public static int[] InsertionSort(int[] source)
        {
            int[] col = CopyArray(source);
            int temp = int.MinValue;

            for (int i = 1; i < col.Length; i++)
            {
                temp = col[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp < col[j])
                    {
                        col[j + 1] = col[j];
                        col[j] = temp;
                    }
                }
            }
            return col;
        }
    }
}
