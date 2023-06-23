using System;

namespace _2292_벌집
{
    class Program
    {
        static void Main(string[] args)
        {
            int inNum = int.Parse(Console.ReadLine());
            int curNum = 1;
            int count = 0;

            while (curNum < inNum)
            {
                count++;
                curNum += 6 * count;
            }
            Console.WriteLine(count + 1);
        }
    }
}
