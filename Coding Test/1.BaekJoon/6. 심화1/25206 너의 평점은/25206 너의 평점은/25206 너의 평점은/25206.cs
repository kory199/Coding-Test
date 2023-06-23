using System;

namespace _25206_너의_평점은
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr;
            double gradePoint = 0;
            string grade;
            double totalPoint = 0;
            double totalSubject = 0;
            double answerPoint = 0;
            string answer;

            for (int i = 0; i < 20; i++)
            {
                inputStr = Console.ReadLine().Split(' ');

                gradePoint = double.Parse(inputStr[1]);
                grade = inputStr[2];

                if (grade.CompareTo("P") != 0)
                {
                    totalPoint += GradePoint(grade) * gradePoint;
                    totalSubject += gradePoint;
                }
            }

            answerPoint = totalPoint / totalSubject;
            answer = answerPoint.ToString("F6");

            Console.WriteLine(answer);
        }

        static double GradePoint(string grade)
        {
            switch (grade)
            {
                case "A+":
                    return 4.5;
                case "A0":
                    return 4.0;
                case "B+":
                    return 3.5;
                case "B0":
                    return 3.0;
                case "C+":
                    return 2.5;
                case "C0":
                    return 2.0;
                case "D+":
                    return 1.5;
                case "D0":
                    return 1.0;
                case "F":
                    return 0.0;
                default:
                    return 0;
            }
        }
    }
}
