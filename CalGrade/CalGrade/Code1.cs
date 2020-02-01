using System;

namespace CalGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            String grade;
            Console.Write("Enter your Score : ");
            int.TryParse(Console.ReadLine(), out score);

            
            
            if (score >= 80)
            {
                grade = "A";
            }
            else if(score >= 75)
            {
                grade = "B+";
            }
            else if (score >= 70)
            {
                grade = "B";
            }
            else if(score >= 65)
            {
                grade = "C+";
            }
            else if (score >= 60)
            {
                grade = "C";
            }
            else if(score >= 55)
            {
                grade = "D+";
            }
            else if (score >= 50)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.Write("Your Grade is :" + grade);
            
        }    
    }
}