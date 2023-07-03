using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 수_정렬하기
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
                inputArray[i] = int.Parse(Console.ReadLine());

            Array.Sort(inputArray);

            for (int i = 0; i < n; i++)
                Console.WriteLine(inputArray[i]);
        }
    }
}
