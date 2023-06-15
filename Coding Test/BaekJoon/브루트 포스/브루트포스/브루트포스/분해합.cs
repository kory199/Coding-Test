using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    class 분해합
    {
        public static void Solution()
        {
            int disassemblySum = int.Parse(Console.ReadLine());
            int sum = 0;
            int constructor = 0;

            for (int i = 0; i < disassemblySum; i++)
            {
                // sum = 생성자 + 각 자리수
                char[] numberDigits = i.ToString().ToCharArray();
                constructor = i;

                for (int j = 0; j < numberDigits.Length; j++)
                    sum += int.Parse(numberDigits[j].ToString());

                if (i + sum == disassemblySum)
                {
                    Console.WriteLine(constructor);
                    break;
                }

                else if (i == disassemblySum - 1 && i + sum != disassemblySum)
                    Console.WriteLine(0);

                sum = 0;
            }
        }
    }
}
