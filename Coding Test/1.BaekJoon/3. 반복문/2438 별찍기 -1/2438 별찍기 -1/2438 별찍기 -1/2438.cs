using System;
using System.Text;

namespace _2438_별찍기__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string intStr = "*";

            for (int i = 0; i < inputNum; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sb.Append(intStr);
                }
                sb.AppendLine(" ");
            }
            Console.WriteLine(sb);
        }
    }
}
