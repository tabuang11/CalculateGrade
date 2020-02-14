using System;

namespace Code3Data
{
    public class Code3
    {
        public string dataGrade;
        static string Testdata(int caseData)
        {
            string gradeResult;
            if (caseData == 1)
            {
                gradeResult = "A";
            }
            else if (caseData == 2)
            {
                gradeResult = "B+";
            }
            else if (caseData == 3)
            {
                gradeResult = "B";
            }
            else if (caseData == 4)
            {
                gradeResult = "C+";
            }
            else if (caseData == 5)
            {
                gradeResult = "C";
            }
            else if (caseData == 6)
            {
                gradeResult = "D+";
            }
            else if (caseData == 7)
            {
                gradeResult = "D";
            }
            else
            {
                gradeResult = "F";
            }

            return gradeResult;
        }

        public Code3(int score)
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