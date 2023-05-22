using System;
using System.Text;

namespace _10871_X보타_작은_수
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder SB = new StringBuilder();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] output1 = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] output2 = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int N = int.Parse(output1[0]);
            int X = int.Parse(output1[1]);

            for (int i = 0; i < N; i++)
            {
                int A = int.Parse(output2[i]);

                if (A < X)
                {
                    SB.Append(A.ToString() + " ");
                }
            }
            Console.WriteLine(SB.ToString());
        }
    }
}
