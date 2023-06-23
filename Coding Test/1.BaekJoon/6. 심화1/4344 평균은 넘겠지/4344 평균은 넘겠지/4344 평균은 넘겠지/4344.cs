using System;

namespace _4344_평균은_넘겠지
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.테스트 케이스 개수 입력 -> 입력받은 문자열을 정수형으로 변환           
            int N = int.Parse(Console.ReadLine());

            // 입력된 테스트 케이스 만큼 반복문 돌리기
            for (int i = 0; i < N; i++)
            {
                // 합계를 입력받을 변수 초기화
                double Sum = 0;

                // 평균을 입력받을 변수 초기화
                double Avg = 0;

                // 평균이 넘는 학생을 카운트 하기위한 변수 초기화
                double Count = 0;

                // 입력값 : 학생수 및 점수로 나누기
                string[] inStr = Console.ReadLine().Split(' ');

                // 2.입력된 string[0]의 크기를 학생수로 입력받음
                int sB = int.Parse(inStr[0]);
                double[] Stu = new double[sB + 1];
                Stu[0] = sB;
                for (int j = 0; j < sB + 1; j++)
                {
                    Stu[j] = int.Parse(inStr[j]);
                    // 테스트케이스 학생별 점수 입력
                    if (j > 0)
                    {
                        Sum += int.Parse(inStr[j]);
                    }
                }

                // 입력된 값을 이용하여 평균구하기
                Avg = Sum / Stu[0];

                // 테스트 케이스 기준으로 평균이 넘는 학생 수 구하기
                for (int k = 1; k < sB + 1; k++)
                {
                    if (Stu[k] > Avg)
                    {
                        Count++;
                    }
                }

                // 평균이 넘는 학생의 비율 출력하기
                // 평균이 넘는 학생의 비율을 출력하기 위한 변수 Answer 초기화
                double Answer = Count / Stu[0];

                // #0.000 = 소수점이 없어도 출력    ex) 40.000
                // ##.### = 소수점이 없으면 출력 x  ex) 40
                Console.WriteLine($"{Answer:#0.000%}");
            }
        }
    }
}
