using System;

namespace _27866_문자와_문자열
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            char[] inputChar;
            int inputNum = 0;

            inputStr = Console.ReadLine();
            inputNum = int.Parse(Console.ReadLine());

            inputChar = inputStr.ToCharArray();

            Console.WriteLine(inputChar[inputNum - 1]);
        }
    }
}
