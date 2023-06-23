using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    class 블랙잭
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int testCase = int.Parse(inputStr[0]);
            int maxNum = int.Parse(inputStr[1]);
            int[] NumArray = new int[testCase];
            int answer = -1;
            string[] testStr = Console.ReadLine().Split(' ');

            for (int i = 0; i < testStr.Length; i++)
                NumArray[i] = int.Parse(testStr[i]);

            for (int i = 0; i < testCase; i++)
            {
                int tempSum = 0;

                if (i + 1 < testCase)
                {
                    for (int j = i + 1; j < testCase; j++)
                    {
                        if (j + 1 < testCase)
                        {
                            for (int k = j + 1; k < testCase; k++)
                            {
                                tempSum = NumArray[i] + NumArray[j] + NumArray[k];

                                if (answer < tempSum && tempSum <= maxNum)
                                    answer = tempSum;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
