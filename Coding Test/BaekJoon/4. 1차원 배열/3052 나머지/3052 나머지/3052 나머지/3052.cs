using System;

namespace _3052_나머지
{
    class Program
    {
        static void Main(string[] args)
        {
            // 크기가 10인 정수형 배열 선언
            int[] Array = new int[10];
            // Count 초기값 설정
            int Count = 10;

            for (int i = 0; i < 10; i++)
            {

                // 입력된 string Array 배열로 삽입
                string inputStr = Console.ReadLine();
                Array[i] = (int.Parse(inputStr)) % 42;
            }

            for (int j = 0; j < 10; j++)
            {
                for (int k = j + 1; k < 10; k++)
                {
                    if (Array[j] == Array[k])
                    {
                        Count--;
                        // 같은 정수를 찾으면 반복 X
                        break;
                    }
                }
            }
            Console.WriteLine(Count);
        }
    }
}
