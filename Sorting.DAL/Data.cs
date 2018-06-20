using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.DAL
{
    public static class Data
    {
        static int[] _ints = { 5, 2, 6, 7, 3, 5, 7, 1, 6, 0 };
        public static int[] GetData(int capacity)
        {
            int[] col = new int[capacity];
            Array.Copy(_ints, col, capacity);

            return col;
        }
    }
}
