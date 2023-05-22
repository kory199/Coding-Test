using System;
using System.Text;

namespace _25314_코딩은_체육과목입니다
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            int repeatNum = 0;
            StringBuilder sb = new StringBuilder();

            inputStr = Console.ReadLine();
            repeatNum = int.Parse(inputStr) / 4;

            for (int i = 0; i < repeatNum; i++)
            {
                sb.Append("long ");
            }

            sb.Append("int");

            Console.WriteLine(sb);
        }
    }
}
