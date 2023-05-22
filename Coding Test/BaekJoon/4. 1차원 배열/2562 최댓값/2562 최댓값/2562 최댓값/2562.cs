using System;

namespace _2562_최댓값
{
    class Program
    {
        static void Main(string[] args)
        {
            // 최댓값이 몇 번쨰 수인지 확인
            int Count = 0;
            // 최댓값 초기화
            int[] MaxNum = new int[9];
            int Max = MaxNum[0];

            for (int i = 0; i < MaxNum.Length; i++)
            {
                MaxNum[i] = int.Parse(Console.ReadLine());

                if (Max < MaxNum[i])
                {
                    Max = MaxNum[i];
                    Count = i + 1;
                }
            }
            Console.WriteLine(Max);
            Console.WriteLine(Count);
        }
    }
}
