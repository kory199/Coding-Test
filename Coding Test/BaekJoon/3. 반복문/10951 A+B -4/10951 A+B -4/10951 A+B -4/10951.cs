using System;

namespace _10951_A_B__4
{
    class Program
    {
        static void Main(string[] args)
        {
            // EOF (End Of File) 활용
            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                string[] output = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int A = int.Parse(output[0]);
                int B = int.Parse(output[1]);
                int C = A + B;

                Console.WriteLine(C);
            }
        }
    }
}
