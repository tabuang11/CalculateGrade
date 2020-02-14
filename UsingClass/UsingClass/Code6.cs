using System;

namespace Code6Data
{
    public class Code6
    {
        public string dataGrade;

        public Code6(int score)
        {
            Boolean checkResult = false;
           
            if (score <= 100 && score > 0)
            {
             
                if (score >= 80)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "A";
                    }
                }
                else if (score >= 75)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "B+";
                    }
                }
                else if (score >= 70)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "B";
                    }
                }
                else if (score >= 65)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "C+";
                    }
                }
                else if (score >= 60)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "C";
                    }
                }
                else if (score >= 55)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "D+";
                    }
                }
                else if (score >= 50)
                {
                    checkResult = true;
                    if (checkResult == true)
                    {
                        dataGrade = "D";
                    }
                }
                else
                {
                    dataGrade = "F";
                }
                    
              
            }            
            else
            {
                dataGrade = "Score must below 100 OR more 0";
            }

        }
    }
}