using System;
using Code1Data;

namespace UsingClass
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.Write("Please input your grade here : ");
            int dataPoint = Console.Read();
            Code1 codedata = new Code1(dataPoint);
            Console.WriteLine(codedata.dataGrade);

        }

    }
}