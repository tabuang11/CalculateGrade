using System;
using Code1Data;
using Code2Data;

namespace UsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                UnitTest();
            } else
            {
                Console.Write("Please input your grade here : ");
                int dataPoint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dataPoint);
                Code1 codedata1 = new Code1(dataPoint);
                Code2 codedata2 = new Code2(dataPoint);

                Console.WriteLine("Code 01 Result :" + codedata1.dataGrade);
                Console.WriteLine("Code 02 Result :" + codedata2.dataGrade);
            }
        }

        static void UnitTest ()
        {

            for (Int16 i = -1; i <= 101; i++)
            {
                Code1 codedata1 = new Code1(i);
                Code2 codedata2 = new Code2(i);
                Code2 codedata3 = new Code2(i);

                if (codedata1.dataGrade != codedata2.dataGrade 
                    || codedata2.dataGrade != codedata3.dataGrade)
                {
                    throw new Exception("Score: " + i + " is not equal Grade");
                }
            }
            Console.WriteLine("Score -1 to 101 checking Grade is Complated.");
        }

    }
}