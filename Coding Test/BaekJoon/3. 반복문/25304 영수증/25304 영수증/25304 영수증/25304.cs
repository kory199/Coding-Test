using System;

namespace _25304_영수증
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int typeNum = int.Parse(Console.ReadLine());

            int sumPrice = 0;

            for (int i = 0; i < typeNum; i++)
            {
                string[] priceNum = Console.ReadLine().Split(' ');

                int price = int.Parse(priceNum[0]);
                int cNum = int.Parse(priceNum[1]);

                sumPrice += price * cNum;
            }

            if (sum == sumPrice)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
