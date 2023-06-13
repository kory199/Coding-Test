using System;
using System.Linq;

namespace 기하_직사각형과_삼각형
{
    class _10101삼각형외우기
    {
        public static void Solution()
        {
            int[] angle = new int[3];
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < 3; i++)
                angle[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                if (maxCount < count)
                    maxCount = count;   
                count = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (angle[i] == angle[j])
                        count++;
                }
            }
            
            if (angle.Sum() != 180)
                Console.WriteLine("Error");

            else if (angle.Sum() == 180)
            {
                switch (maxCount)
                {
                    case 1:
                        Console.WriteLine("Scalene");
                        break;
                    case 2:
                        Console.WriteLine("Isosceles");
                        break;
                    case 3:
                        Console.WriteLine("Equilateral");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
