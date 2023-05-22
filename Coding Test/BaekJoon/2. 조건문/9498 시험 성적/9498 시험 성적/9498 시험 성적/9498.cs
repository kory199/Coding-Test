using System;

namespace _9498_시험_성적
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int inputNum = int.Parse(inputStr);

            if (inputNum >= 90 && inputNum <= 100)
            {
                Console.WriteLine("A");
            }

            else if (inputNum >= 80 && inputNum <= 89)
            {
                Console.WriteLine("B");
            }

            else if (inputNum >= 70 && inputNum <= 79)
            {
                Console.WriteLine("C");
            }

            else if (inputNum >= 60 && inputNum <= 69)
            {
                Console.WriteLine("D");
            }

            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
