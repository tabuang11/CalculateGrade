using System;

namespace Code4Data
{
    public class Code4
    {
        public string dataGrade;
        public Code4(int score)
        {
            if (score <=100 && score > 0 )
            {
                string grade;
                float dataCal = score * 10;
                float cal = dataCal/100;
                if (cal >= 8)
                {
                    grade = "A";
                }
                else if (cal >= 7.5)
                {
                    grade = "B+";
                }
                else if (cal >= 7)
                {
                    grade = "B";
                }
                else if (cal >= 6.5)
                {
                    grade = "C+";
                }
                else if (cal >= 6)
                {
                    grade = "C";
                }
                else if (cal >= 5.5)
                {
                    grade = "D+";
                }
                else if (cal >= 5)
                {
                    grade = "D";
                }
                else 
                {
                    grade = "F";
                }

                dataGrade = grade;
            }
            else
            {
                dataGrade = "Score must below 100 OR more 0";
            }
            
        }
    }
}