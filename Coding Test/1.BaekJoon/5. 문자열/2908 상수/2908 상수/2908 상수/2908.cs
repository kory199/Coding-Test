using System;

namespace _2908_상수
{
    class Program
    {
        static void Main(string[] args)
        {
            // 두개의 세자리 자연수 입력
            string[] inStr = Console.ReadLine().Split(' ');


            // 1번 풀이
            // -------------------------------------------------------------------------------
            // string 으로 입력받은 세자리 자연수를 정수형으로 변환
            int inStr1 = int.Parse(inStr[0]);
            int inStr2 = int.Parse(inStr[1]);

            // 입력받은 정수의 앞,뒷자리를 바꿈
            int Answer1 = ((inStr1 % 10) * 100) + ((inStr1 % 100) / 10) * 10 + (inStr1 / 100);
            int Answer2 = ((inStr2 % 10) * 100) + ((inStr2 % 100) / 10) * 10 + (inStr2 / 100);

            if (Answer1 > Answer2)
            {
                Console.WriteLine(Answer1);
            }
            else
            {
                Console.WriteLine(Answer2);
            }
            // -------------------------------------------------------------------------------



            // 2번 풀이 (~ing)
            // inStr[][]은 char 형으로 int 변환시 아스키 코드값이 들어감
            // 따라서 문자의 합이(char 3 + 4 +5 => string 345 )나 다른 방법으로 풀이를 더 생각해 봐야됨

            /*int Answer1 = (int)inStr[0][2]*100 + (int)inStr[0][1]*10 + (int)inStr[0][0];
            Console.WriteLine(((int)inStr[0][2])*100);
            Console.WriteLine((int)inStr[0][1]);
            Console.WriteLine(inStr[0][0]);
            Console.WriteLine(Answer1);*/
        }
    }
}
