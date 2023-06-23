using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하_직사각형과_삼각형
{
    class _5073삼각형과세변
    {
        public static void Solution()
        {
            int count = 0;
            int maxCount = -1;

            while (true)
            {
                List<int> triangle = new List<int>();
                string[] inputStr = Console.ReadLine().Split(' ');

                count = 0;
                triangle.Add(int.Parse(inputStr[0]));
                triangle.Add(int.Parse(inputStr[1]));
                triangle.Add(int.Parse(inputStr[2]));
                triangle.Sort();

                if (triangle.Sum() == 0)
                    break;
                if (triangle[2] >= triangle[0] + triangle[1])
                {
                    Console.WriteLine("Invalid");
                    continue;
                }

                for (int i = 0; i < 3; i++)
                {
                    if (maxCount < count)
                        maxCount = count;
                    count = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        if (triangle[i] == triangle[j])
                        {
                            count++;
                        }
                    }
                }

                triangle.Clear();

                switch (maxCount)
                {
                    case 1:
                        Console.WriteLine("Scalene");
                        maxCount = 0;
                        break;
                    case 2:
                        Console.WriteLine("Isosceles");
                        maxCount = 0;
                        break;
                    case 3:
                        Console.WriteLine("Equilateral");
                        maxCount = 0;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
