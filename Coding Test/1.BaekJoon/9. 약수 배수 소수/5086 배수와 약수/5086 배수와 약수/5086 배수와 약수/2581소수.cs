using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _2581소수
    {
        public static void Solution()
        {
            List<int> decimalNumbers = new List<int>();
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= Num2 - Num1; i++)
            {
                int temp = 0;
                int transNum = i + Num1;

                if (Num1 == 0)
                    continue;

                for (int j = 1; j <= transNum; j++)
                {
                    if (transNum % j == 0)
                        temp += j;
                }

                if (temp == transNum + 1)
                    decimalNumbers.Add(transNum);
            }

            if (decimalNumbers.Count == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine(decimalNumbers.Sum());
                Console.WriteLine(decimalNumbers[0]);
            }
        }
    }
}
