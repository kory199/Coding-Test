using System;

namespace _2884_알람_시계
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTime = Console.ReadLine().Split(' ');
            int hour = int.Parse(inputTime[0]);
            int minute = int.Parse(inputTime[1]);

            if (minute - 45 < 0 && hour == 0)
            {
                hour = 23;
                minute += 60 - 45;
            }

            else if (minute - 45 < 0)
            {
                hour = hour - 1;
                minute += 60 - 45;
            }

            else
            {
                minute -= 45;
            }
            Console.Write($"{hour} {minute}");
        }
    }
}
