using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    internal class 설탕_배달
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int bagCount = 0;

            while (true)
            {
                if (n % 5 == 0 && n != 0)
                {
                    n -= 5;
                    bagCount++;
                }

                else if (n % 3 == 0 && n != 0)
                {
                    n -= 3;
                    bagCount++;
                }
                
                else if(n > 5)
                {
                    n -= 5;
                    bagCount++;
                }

                else if (n == 0)
                    break;

                else
                {
                    bagCount = -1;
                    break;
                }
            }

            Console.WriteLine(bagCount);
        }
    }
}
