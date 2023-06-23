using System;
using System.Text;

namespace _10952_A_B__5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder SB = new StringBuilder();


            while (true)
            {
                string input = Console.ReadLine();
                string[] output = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int A = int.Parse(output[0]);
                int B = int.Parse(output[1]);
                int C = A + B;

                if (A == 0 && B == 0)
                {
                    break;
                }

                else
                {
                    SB.AppendLine(C.ToString());
                }
            }
            Console.WriteLine(SB);
        }
    }
}
