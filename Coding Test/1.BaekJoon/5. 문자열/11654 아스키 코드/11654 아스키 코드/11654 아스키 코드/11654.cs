using System;

namespace _11654_아스키_코드
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열(string) 입력 후 문자(Char)로 변환 
            char inChar = Convert.ToChar(Console.ReadLine());

            // 문자열 -> 아스키 코드 값으로 변환 

            int inNum = Convert.ToInt32(inChar);

            Console.WriteLine(inNum);
        }
    }
}
