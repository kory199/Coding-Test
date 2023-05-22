using System;

namespace _1000_A_B
{
    class 1000
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
        }
    }
}
