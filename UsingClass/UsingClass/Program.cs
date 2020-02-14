using System;
using Code1Data;
using Code2Data;
using Code3Data;
using Code4Data;
using Code5Data;
using Code6Data;
using Code7Data;
using Code8Data;
using Code9Data;
using Code10Data;

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
                Code1 codedata1 = new Code1(dataPoint);
                Code2 codedata2 = new Code2(dataPoint);
                Code3 codedata3 = new Code3(dataPoint);
                Code4 codedata4 = new Code4(dataPoint);
                Code5 codedata5 = new Code5(dataPoint);
                Code6 codedata6 = new Code6(dataPoint);
                Code7 codedata7 = new Code7(dataPoint);
                Code8 codedata8 = new Code8(dataPoint);
                Code9 codedata9 = new Code9(dataPoint);
                Code10 codedata10 = new Code10(dataPoint);

                Console.WriteLine("Code 01 Result :" + codedata1.dataGrade);
                Console.WriteLine("Code 02 Result :" + codedata2.dataGrade);
                Console.WriteLine("Code 03 Result :" + codedata3.dataGrade);
                Console.WriteLine("Code 04 Result :" + codedata4.dataGrade);
                Console.WriteLine("Code 05 Result :" + codedata5.dataGrade);
                Console.WriteLine("Code 06 Result :" + codedata6.dataGrade);
                Console.WriteLine("Code 07 Result :" + codedata7.dataGrade);
                Console.WriteLine("Code 08 Result :" + codedata8.dataGrade);
                Console.WriteLine("Code 09 Result :" + codedata9.dataGrade);
                Console.WriteLine("Code 10 Result :" + codedata10.dataGrade);
            }
        }

        static void UnitTest ()
        {

            for (Int16 i = -1; i <= 101; i++)
            {
                Code1 codedata1 = new Code1(i);
                Code2 codedata2 = new Code2(i);
                Code3 codedata3 = new Code3(i);
                Code4 codedata4 = new Code4(i);
                Code5 codedata5 = new Code5(i);
                Code6 codedata6 = new Code6(i);
                Code7 codedata7 = new Code7(i);
                Code8 codedata8 = new Code8(i);
                Code9 codedata9 = new Code9(i);
                Code10 codedata10 = new Code10(i);

                if (codedata1.dataGrade != codedata2.dataGrade 
                    || codedata2.dataGrade != codedata3.dataGrade
                    || codedata3.dataGrade != codedata4.dataGrade
                    || codedata4.dataGrade != codedata5.dataGrade
                    || codedata5.dataGrade != codedata6.dataGrade
                    || codedata6.dataGrade != codedata7.dataGrade
                    || codedata7.dataGrade != codedata8.dataGrade
                    || codedata8.dataGrade != codedata9.dataGrade
                    || codedata9.dataGrade != codedata10.dataGrade
                    )
                {
                    throw new Exception("Score: " + i + " is not equal Grade");
                }
            }
            Console.WriteLine("Score -1 to 101 checking Grade is Complated.");
        }

    }
}