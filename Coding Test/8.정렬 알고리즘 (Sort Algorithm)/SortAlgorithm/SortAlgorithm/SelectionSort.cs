using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class SelectionSort
    {
        public static void Solution()
        {
            int[] array = { 1, 0, 3, 2, 5, 4, 6, 8, 7, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                int min = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
