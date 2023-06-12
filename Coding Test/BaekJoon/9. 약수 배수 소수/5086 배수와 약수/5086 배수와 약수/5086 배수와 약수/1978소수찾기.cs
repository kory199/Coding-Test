using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _1978소수찾기
    {
        public static void Solution()
        {
            int testCase = int.Parse(Console.ReadLine());
            string[] inputStr;
            int count = 0;
            int[] decimalNum = new int[testCase];
            inputStr = Console.ReadLine().Split(' ');

            for (int i = 0; i < testCase; i++)
            {
                int temp = 0;

                decimalNum[i] = int.Parse(inputStr[i]);

                if (decimalNum[i] == 1)
                    continue;
                for (int j = 1; j <= decimalNum[i]; j++)
                {
                    if (decimalNum[i] % j == 0)
                        temp += j;
                }

                if (temp == decimalNum[i] + 1)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
