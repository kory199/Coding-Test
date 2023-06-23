using System;
using System.Text;

namespace _15552_빠른_A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputNum; i++)
            {
                string[] inputStr = Console.ReadLine().Split();

                int firstNum = 0, secondNum = 0;

                firstNum = int.Parse(inputStr[0]);
                secondNum = int.Parse(inputStr[1]);

                sb.AppendLine((firstNum + secondNum).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
