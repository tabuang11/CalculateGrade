﻿using System;

namespace Code9Data
{
    public class Code9
    {
        static int dataOfGrade(double datasocre)
        {
           
            int calData;

            if (datasocre >= 8)
            {
                calData = 0;
            }
            else if (datasocre >= 7.5)
            {
                calData = 1;
            }
            else if (datasocre >= 7)
            {
                calData = 2;
            }
            else if (datasocre >= 6.5)
            {
                calData = 3;
            }
            else if (datasocre >= 6)
            {
                calData = 4;
            }
            else if (datasocre >= 5.5)
            {
                calData = 5;
            }
            else if (datasocre >= 5)
            {
                calData = 6;
            }
            else
            {
                calData = 7;
            }

            return calData;

        }
        
        public string dataGrade;
        public Code9(int score)
        {
            if (score <= 100 && score > 0)
            {
                int dataControlcal;
                string controlGrade;
                double dataCal = score/10.0;
                string[] grade = {"A", "B+", "B", "C+", "C", "D+", "D", "F"};
                
                dataControlcal = dataOfGrade(dataCal);
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