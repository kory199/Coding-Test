using System;
using System.Collections.Generic;
using System.Text;

namespace 집합과_맵
{
    internal class 회사에_있는_사람
    {
        public static void Solution()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, bool> person = new Dictionary<string, bool>();
            List<string> workPerson = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                string name = temp[0];
                string check = temp[1];

                // 문자열 비교의 경우 시간복잡도가 O(N)이므로 for문에서 문자열 비교는 O(N2)의 시간복잡도
                // 따라서 캐릭터형(Char) 비교 (시간복잡도 O(1))를 사용
                if (check[0] == 'e')
                    person[name] = true;
                else
                    person[name] = false;
            }

            foreach (var item in person)
            {
                if (item.Value == true)
                    workPerson.Add(item.Key);
            }

            workPerson.Sort((x, y) => y.CompareTo(x));

            foreach (var item in workPerson)
                sb.AppendLine(item);

            Console.WriteLine(sb);
        }
    }
}
