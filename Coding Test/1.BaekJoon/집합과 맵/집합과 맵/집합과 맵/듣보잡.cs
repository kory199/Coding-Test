using System;
using System.Collections.Generic;
using System.Text;

namespace 집합과_맵
{
    internal class 듣보잡
    {
        public static void Solution()
        {
            int[] inputNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int peopleNum = inputNum[0];
            int findPeopleNum = inputNum[1];

            Dictionary<string, short> notMentionPeople = new Dictionary<string, short>();
            List<string> answerPeople = new List<string>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < peopleNum; i++)
            {
                string peopleName = Console.ReadLine();
                notMentionPeople.Add(peopleName, 1);
            }

            for (int i = 0; i < findPeopleNum; i++)
            {
                string findName = Console.ReadLine();

                if (notMentionPeople.ContainsKey(findName))
                    answerPeople.Add(findName);
            }

            answerPeople.Sort();
            sb.AppendLine(answerPeople.Count.ToString());

            for (int i = 0; i < answerPeople.Count; i++)
                sb.AppendLine(answerPeople[i]);

            Console.WriteLine(sb);
        }
    }
}
