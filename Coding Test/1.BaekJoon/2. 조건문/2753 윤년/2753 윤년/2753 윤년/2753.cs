using System;

namespace _2753_윤년
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year = int.Parse(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
