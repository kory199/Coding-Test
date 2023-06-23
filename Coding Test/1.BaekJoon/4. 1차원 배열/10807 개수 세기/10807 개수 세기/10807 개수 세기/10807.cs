using System;

namespace _10807_개수_세기
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string inputStr = Console.ReadLine();
            string[] splitStr = inputStr.Split(' ');
            int[] inputNum = new int[num];
            int countNum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < num; i++)
            {
                inputNum[i] = int.Parse(splitStr[i]);
            }

            for (int i = 0; i < num; i++)
            {
                if (inputNum[i] == countNum) { count++; }
            }

            Console.WriteLine(count);
        }
    }
}
