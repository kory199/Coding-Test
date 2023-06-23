using System;

namespace _11021_A_B__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int inNum = int.Parse(Console.ReadLine());
            int Answer = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inNum; i++)
            {
                string[] inStr = Console.ReadLine().Split(' ');

                Answer = int.Parse(inStr[0]) + int.Parse(inStr[1]);

                sb.AppendLine($"Case #" + i + ": " + Answer.ToString());
            }
            Console.Write(sb);
        }
    }
}
