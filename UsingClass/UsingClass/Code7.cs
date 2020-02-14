using System;

namespace Code7Data
{
    public class Code7
    {
        public string dataGrade;
        static string Testdata(int caseData)
        {
            string gradeResult;

            switch (caseData)
            {
             case 1:
                 gradeResult = "A";
                 break;
             case 2:
                 gradeResult = "B+";
                 break;
             case 3:
                 gradeResult = "B";
                 break;
             case 4:
                 gradeResult = "C+";
                 break;
             case 5:
                 gradeResult = "C";
                 break;
             case 6:
                 gradeResult = "D+";
                 break;
             case 7:
                 gradeResult = "D";
                 break;
             default:
                 gradeResult = "F";
                 break;
            }
           return gradeResult;
        }

        public Code7(int score)
        {
            if (score > 0 && score <= 100)
            {
                int dataForCheck;
                if (score <= 100 && score >= 80)
                {
                    dataForCheck = 1;
                }
                else if (score <= 79 && score >= 75)
                {
                    dataForCheck = 2;
                }
                else if (score <= 74 && score >= 70)
                {
                    dataForCheck = 3;
                }
                else if (score <= 69 && score >= 65)
                {
                    dataForCheck = 4;
                }
                else if (score <= 64 && score >= 60)
                {
                    dataForCheck = 5;
                }
                else if (score <= 59 && score >= 55)
                {
                    dataForCheck = 6;
                }
                else if (score <= 54 && score >= 50)
                {
                    dataForCheck = 7;
                }
                else
                {
                    dataForCheck = 8;
                }
                string dataoFGrade = Testdata(dataForCheck);
                dataGrade = dataoFGrade;
            }
            else
            {
                dataGrade = "Score must below 100 OR more 0";
            }
            
        }
    }
}