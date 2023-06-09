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
            string today = "2022.05.19";
            string[] terms = { "A 6", "B 12", "C 3" };
            string[] privacles = { "2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C" };

            LV1개인정보수집유효기간.solution(today, terms, privacles );
        }
    }
}
