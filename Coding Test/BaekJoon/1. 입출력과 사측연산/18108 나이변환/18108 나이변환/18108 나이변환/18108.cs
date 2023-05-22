using System;

namespace _18108_나이변환
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year = 0;
            int TransYear = 0;

            string Str = Console.ReadLine();

            Year = int.Parse(Str);
            TransYear = Year - 543;

            Console.WriteLine(TransYear);
        }
    }
}
