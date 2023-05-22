using System;

namespace _10869_사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = null;
            int A = 0;
            int B = 0;

            inputStr = Console.ReadLine().Split(' ');

            A = int.Parse(inputStr[0]);
            B = int.Parse(inputStr[1]);

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
    }
}
