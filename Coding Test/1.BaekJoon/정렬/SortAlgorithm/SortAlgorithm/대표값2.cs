using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 대표값2
    {
        public static void Solution()
        {
            List<int> inputArray = new List<int>();

            for (int i = 0; i < 5; i++)
                inputArray.Add(int.Parse(Console.ReadLine()));
            inputArray.Sort();
            Console.WriteLine(inputArray.Average());
            Console.WriteLine(inputArray[2]);
        }
    }
}
