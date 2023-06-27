using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] com = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            LV1_K번쨰수.solution(array, com);
        }
    }
}
