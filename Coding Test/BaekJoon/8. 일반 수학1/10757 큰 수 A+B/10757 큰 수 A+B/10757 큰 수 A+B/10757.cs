using System;
using System.Numerics;

namespace _10757_큰_수_A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().Split(' ');

            BigInteger inputNum1 = BigInteger.Parse(inputStr[0]);
            BigInteger inputNum2 = BigInteger.Parse(inputStr[1]);

            Console.WriteLine(inputNum1 + inputNum2);
        }
    }
}
