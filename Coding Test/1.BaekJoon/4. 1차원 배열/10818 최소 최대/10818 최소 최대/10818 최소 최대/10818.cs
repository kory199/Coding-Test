using System;

namespace _10818_최소_최대
{
    class Program
    {
        static void Main(string[] args)
        {
            // N개의 정수 설정
            int Num = int.Parse(Console.ReadLine());

            while (true)
            {

                string inputNum = Console.ReadLine();
                string[] outputNum = inputNum.Split(' ');

                // 최대, 최소값 저장을 위한 변수 초기화

                int N1 = int.Parse(outputNum[0]);
                int N2 = int.Parse(outputNum[0]);

                for (int j = 0; j < Num; j++)
                {
                    if (N1 < int.Parse(outputNum[j]))
                    {
                        N1 = int.Parse(outputNum[j]);
                    }

                }

                for (int k = 0; k < Num; k++)
                {
                    if (N2 > int.Parse(outputNum[k]))
                    {
                        N2 = int.Parse(outputNum[k]);
                    }
                }
                // $ : 문자열 내 변수 자동인식
                Console.WriteLine($"{N2} {N1}");
                break;
            }
        }
    }
}
