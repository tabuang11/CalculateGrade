using System;

namespace Code8Data
{
    public class Code8
    {
        public string dataGrade;
        public Code8(int score)
        {
   
            if (score <= 100 && score > 0)
            {
                double dataCal = score/10.0;
                string[] grade = {"A", "B+", "B", "C+", "C", "D+", "D", "F"};
                int calData;
                int dataControlcal;
                string controlGrade;
                if (dataCal >= 8)
                {
                    calData = 0;
                }
                else if (dataCal >= 7.5)
                {
                    calData = 1;
                }
                else if (dataCal >= 7)
                {
                    calData = 2;
                }
                else if (dataCal >= 6.5)
                {
                    calData = 3;
                }
                else if (dataCal >= 6)
                {
                    calData = 4;
                }
                else if (dataCal >= 5.5)
                {
                    calData = 5;
                }
                else if (dataCal >= 5)
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
