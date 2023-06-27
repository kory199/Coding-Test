using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1공원산책
    {
        public static int[] solution(string[] park, string[] routes)
        {
            int[] answer = new int[2];

            int startpointH = 0;
            int startpointW = 0;

            char[,] parkMap = new char[park.Length, park[0].Length];
            char[] transChar;

            char[] routesDirection = new char[routes.Length];
            int[] routesDistance = new int[routes.Length];

            int checkMap = 0;

            for (int i = 0; i < park.Length; i++)
            {
                for (int j = 0; j < park[0].Length; j++)
                {
                    transChar = park[i].ToCharArray();
                    parkMap[i, j] = transChar[j];

                    if (transChar[j] == 'S')
                    {
                        startpointH = i;
                        startpointW = j;
                    }
                }
            }

            for (int i = 0; i < routes.Length; i++)
            {
                transChar = routes[i].ToCharArray();
                routesDirection[i] = transChar[0];
                routesDistance[i] = int.Parse(transChar[2].ToString());
            }

            for (int i = 0; i < routes.Length; i++)
            {
                switch (routesDirection[i])
                {
                    case 'E':
                        for (int j = 1; j < park[0].Length; j++)
                        {
                            if (startpointW + j < park[0].Length && startpointH < park.Length)
                            {
                                if (parkMap[startpointH, startpointW + j] == 'O' || parkMap[startpointH, startpointW + j] == 'S')
                                {
                                    checkMap++;
                                }
                                else if (parkMap[startpointH, startpointW + j] == 'X')
                                {
                                    break;      
                                }
                            }
                            else
                                break;
                        }
                        if (routesDistance[i] <= checkMap)
                        {
                            startpointW += routesDistance[i];
                        }
                        break;
                    case 'W':
                        for (int j = 1; j < park[0].Length; j++)
                        {
                            if (startpointW - j >= 0 && startpointH < park.Length)
                            {
                                if (parkMap[startpointH, startpointW - j] == 'O' || parkMap[startpointH, startpointW - j] == 'S')
                                {
                                    checkMap++;
                                }
                                else if (parkMap[startpointH, startpointW - j] == 'X')
                                {
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        if (routesDistance[i] <= checkMap)
                        {
                            startpointW -= routesDistance[i];
                        }
                        break;
                    case 'S':
                        for (int j = 1; j < park[0].Length; j++)
                        {
                            if (startpointH + j < park.Length && startpointW< park[0].Length)
                            {
                                if (parkMap[startpointH + j, startpointW] == 'O' || parkMap[startpointH + j, startpointW] == 'S')
                                {
                                    checkMap++;
                                }
                                else if (parkMap[startpointH + j, startpointW] == 'X')
                                {
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        if (routesDistance[i] <= checkMap)
                        {
                            startpointH += routesDistance[i];
                        }
                        break;
                    case 'N':
                        for (int j = 1; j < park[0].Length; j++)
                        {
                            if (startpointH - j >= 0 && startpointW < park[0].Length)
                            {
                                if (parkMap[startpointH - j, startpointW] == 'O' || parkMap[startpointH - j, startpointW] == 'S')
                                {
                                    checkMap++;
                                }
                                else if (parkMap[startpointH - j, startpointW] == 'X')
                                {
                                    break;
                                }
                            }
                            else
                                break;
                        }
                        if (routesDistance[i] <= checkMap)
                        {
                            startpointH -= routesDistance[i];
                        }
                        break;
                }
                checkMap = 0;
            }

            answer[0] = startpointH;
            answer[1] = startpointW;
            return answer;
        }
    }
}
