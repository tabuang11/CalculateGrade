using System;
using Code1Data;
using Code2Data;

namespace UsingClass
{
    class Program
    {
        static void Main(string[] args)
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
}