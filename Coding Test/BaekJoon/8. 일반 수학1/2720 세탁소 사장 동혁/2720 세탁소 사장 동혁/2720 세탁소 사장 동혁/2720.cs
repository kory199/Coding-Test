using System;

namespace _2720_세탁소_사장_동혁
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = Console.ReadLine();
            string changeCoin;

            int coin = 0;

            int[] changes = { 25, 10, 5, 1 };

            int[] answer = new int[4];

            for (int i = 0; i < int.Parse(testStr); i++)
            {
                changeCoin = Console.ReadLine();
                coin = int.Parse(changeCoin);

                for (int j = 0; j < 4; j++)
                {
                    answer[j] = coin / changes[j];
                    coin = coin % changes[j];

                    Console.Write(answer[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
