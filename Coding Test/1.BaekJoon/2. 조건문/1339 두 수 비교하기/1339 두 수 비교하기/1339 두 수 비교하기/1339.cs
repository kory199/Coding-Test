using System;

namespace _1339_두_수_비교하기
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int[] inputNum = { int.Parse(inputStr[0]), int.Parse(inputStr[1]) };

            if (inputNum[0] > inputNum[1])
            {
                Console.WriteLine(">");
            }

            else if (inputNum[0] < inputNum[1])
            {
                Console.WriteLine("<");
            }

            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
