using System;

namespace Code5Data
{
    public class Code5
    {
        public string dataGrade;
        public Code5(int score)
        {
   
            if (score <= 100 && score > 0)
            {
                string[] grade = {"A", "B+", "B", "C+", "C", "D+", "D", "F"};
                int calData;
                int dataControlcal;
                string controlGrade;
                if (score >= 80)
                {
                    calData = 0;
                }
                else if (score >= 75)
                {
                    calData = 1;
                }
                else if (score >= 70)
                {
                    calData = 2;
                }
                else if (score >= 65)
                {
                    calData = 3;
                }
                else if (score >= 60)
                {
                    calData = 4;
                }
                else if (score >= 55)
                {
                    calData = 5;
                }
                else if (score >= 50)
                {
                    calData = 6;
                }
                else
                {
                    calData = 7;
                }

                dataControlcal = calData;
                controlGrade = grade[dataControlcal];
                dataGrade = controlGrade;
            }
            else
            {
                dataGrade = "Score must below 100 OR more 0";
            }
        }
        
    }
}