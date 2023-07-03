using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 소트인사이드
    {
        public static void Solution()
        {
            string inputStr = Console.ReadLine();
            char[] inputChar = new char[inputStr.Length];

            for (int i = 0; i < inputStr.Length; i++)
                inputChar[i] = inputStr[i];

            Array.Sort(inputChar);
            Array.Reverse(inputChar);

            for (int i = 0; i < inputChar.Length; i++)
                Console.Write(inputChar[i]);
        }
    }
}
