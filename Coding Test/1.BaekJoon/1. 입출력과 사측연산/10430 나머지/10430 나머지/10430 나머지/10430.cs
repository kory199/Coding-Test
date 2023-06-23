using System;

namespace _10430_나머지
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;

            string[] inputStr = Console.ReadLine().Split(' ');

            A = int.Parse(inputStr[0]);
            B = int.Parse(inputStr[1]);
            C = int.Parse(inputStr[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
