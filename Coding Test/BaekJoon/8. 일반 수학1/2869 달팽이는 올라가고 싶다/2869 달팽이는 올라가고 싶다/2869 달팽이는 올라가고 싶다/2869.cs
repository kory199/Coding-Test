using System;

namespace _2869_달팽이는_올라가고_싶다
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inStr = Console.ReadLine().Split(' ');
            double up = double.Parse(inStr[0]);
            double down = double.Parse(inStr[1]);
            double height = int.Parse(inStr[2]);
            double day = 0;

            day = (height - down) / (up - down);

            Console.WriteLine(Math.Ceiling(day));
        }
    }
}
