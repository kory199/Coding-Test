using System;

namespace _2941_크로아티아_알파벳
{
    class Program
    {
        static void Main(string[] args)
        {
            // 알파벳 소문자 및 -, = 이 포함 될 수 있는 문자열 입력
            string inStr = Console.ReadLine();

            // 알파벳을 카운트 하기위한 변수설정
            int Count = 0;

            // 입력된 문자열에서 크로아티아 알파벳의 개수를 출력
            for (int i = 0; i < inStr.Length; i++)
            {
                // 입력된 문자가 크로아티아 알파벳일 경우 다음 문자열 혹은
                // 다다음 문자열 카운트 생략

                // dz= 경우 3자리이므로
                if (i < inStr.Length - 2)
                {
                    if (inStr[i] == 'c')
                    {
                        if (inStr[i + 1] == '=')
                        {
                            Count++;
                            i += 1;
                            continue;
                        }

                        else if (inStr[i + 1] == '-')
                        {
                            Count++;
                            i += 1;
                            continue;
                        }

                        else
                        {
                            Count++;
                            continue;
                        }
                    }

                    else if (inStr[i] == 'd')
                    {
                        if (inStr[i + 1] == 'z' && inStr[i + 2] == '=')
                        {
                            Count++;
                            i += 2;
                            continue;
                        }

                        if (inStr[i + 1] == '-')
                        {
                            Count++;
                            i += 1;
                            continue;
                        }

                        else
                        {
                            Count++;
                            continue;
                        }
                    }

                    else if (inStr[i] == 'l' && inStr[i + 1] == 'j')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 'n' && inStr[i + 1] == 'j')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 's' && inStr[i + 1] == '=')
                    {
                        Count++;

                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 'z' && inStr[i + 1] == '=')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    // 일반 알파벳일 경우
                    else
                    {
                        Count++;
                    }
                }

                else if (i >= inStr.Length - 2 && i < inStr.Length - 1)
                {
                    if (inStr[i] == 'c')
                    {
                        if (inStr[i + 1] == '=')
                        {
                            Count++;
                            i += 1;
                            continue;
                        }

                        else if (inStr[i + 1] == '-')
                        {
                            Count++;
                            i += 1;
                            continue;
                        }

                        else
                        {
                            Count++;
                            continue;
                        }
                    }

                    else if (inStr[i] == 'd' && inStr[i + 1] == '-')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 'l' && inStr[i + 1] == 'j')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 'n' && inStr[i + 1] == 'j')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 's' && inStr[i + 1] == '=')
                    {
                        Count++;

                        i += 1;
                        continue;
                    }

                    else if (inStr[i] == 'z' && inStr[i + 1] == '=')
                    {
                        Count++;
                        i += 1;
                        continue;
                    }

                    // 일반 알파벳일 경우
                    else
                    {
                        Count++;
                    }
                }

                // 일반 알파벳일 경우
                else
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
