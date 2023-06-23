using System;

namespace _11382_꼬마_장인
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr;

            long A = 0;
            long B = 0;
            long C = 0;

            inputStr = Console.ReadLine().Split();

            A = long.Parse(inputStr[0]);
            B = long.Parse(inputStr[1]);
            C = long.Parse(inputStr[2]);

            Console.WriteLine(A + B + C);
        }
    }
}
