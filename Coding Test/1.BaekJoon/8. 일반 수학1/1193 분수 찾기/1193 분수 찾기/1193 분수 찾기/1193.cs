using System;

namespace _1193_분수_찾기
{
    class Program
    {
        static void Main(string[] args)
        {
            int inNum = int.Parse(Console.ReadLine());

            int totalNum = 0;
            int count = 0;


            while (totalNum < inNum)
            {
                count++;
                totalNum += count;

                if (inNum == 1)
                {
                    Console.WriteLine("1/1");
                }

                if (totalNum > inNum)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine((count - (totalNum - inNum)) + "/" + (totalNum - (inNum - 1)));
                    }

                    else if (count % 2 == 1)
                    {
                        Console.WriteLine((totalNum - (inNum - 1)) + "/" + (count - (totalNum - inNum)));
                    }
                }
                else if (inNum > 1 && totalNum == inNum)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine(count + "/1");
                    }

                    else if (count % 2 == 1)
                    {
                        Console.WriteLine("1/" + count);
                    }
                }
            }
        }
    }
}
