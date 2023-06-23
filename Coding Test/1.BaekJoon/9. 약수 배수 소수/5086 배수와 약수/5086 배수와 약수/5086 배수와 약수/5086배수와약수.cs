using System;
using System.Collections.Generic;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _5086배수와약수
    {
        public static void Solution()
        {
            int num1 = 0;
            int num2 = 0;
            int factor = 0;
            int multiple = 0;
            int neither = 0;
            int temp1 = 0;
            int temp2 = 0;


            while (true)
            {
                factor = 0;
                multiple = 0;
                neither = 0;
                temp1 = 0;
                temp2 = 0;

                string[] inputStr = Console.ReadLine().Split(' ');
                num1 = int.Parse(inputStr[0]);
                num2 = int.Parse(inputStr[1]);

                if (num1 == 0 && num2 == 0)
                {
                    break;
                }

                factor = num2 / num1;
                temp1 = num2 % num1;
                multiple = num1 / num2;
                temp2 = num1 % num2;

                if (factor > 0 && temp1 == 0)
                {
                    Console.WriteLine("factor");
                }

                else if (multiple > 0 && temp2 == 0)
                {
                    Console.WriteLine("multiple");
                }

                else
                {
                    Console.WriteLine("neither");
                }
            }
        }
    }
}
