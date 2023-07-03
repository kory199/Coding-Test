using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    internal class 영화감독숌
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int count = 0;

            while (count != n)
            {
                temp++;
                if (temp.ToString().Contains("666"))
                    count++;
            }
            
            Console.WriteLine(temp);
        }
    }
}
