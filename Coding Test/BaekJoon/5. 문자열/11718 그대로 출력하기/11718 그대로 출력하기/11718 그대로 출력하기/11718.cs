using System;

namespace _11718_그대로_출력하기
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;

            while (true)
            {
                inputStr = Console.ReadLine();

                Console.WriteLine(inputStr);

                if (string.IsNullOrEmpty(inputStr))
                {
                    break;
                }
            }
        }
    }
}
