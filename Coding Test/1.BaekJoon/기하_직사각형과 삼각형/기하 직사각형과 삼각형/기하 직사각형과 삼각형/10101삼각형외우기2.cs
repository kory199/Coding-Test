using System.IO;
using System.Text;
using System;
using System.Collections.Generic;

namespace 기하_직사각형과_삼각형
{
    class _10101삼각형외우기2
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput(), Encoding.Default);
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default);

        public static void Solution()
        {
            // hashset 중복된 요소를 배제한 유일한 요소 저장
            HashSet<int> set = new HashSet<int>();
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int c = int.Parse(sr.ReadLine());
            set.Add(a);
            set.Add(b);
            set.Add(c);
            if ((a + b + c).Equals(180))
            {
                if (set.Count.Equals(1))
                {
                    sw.Write("Equilateral");
                }
                else if (set.Count.Equals(2))
                {
                    sw.Write("Isosceles");
                }
                else
                {
                    sw.Write("Scalene");
                }

            }
            else
            {
                sw.Write("Error");
            }
            sw.Close();
        }
    }
}
