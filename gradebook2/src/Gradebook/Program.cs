using System;
using System.Collections.Generic;

namespace gradebook2
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var (implictily typed) requires intialization
            var grades = new List<double>(){22.5, 42.2, 17.8};
            grades.Add(13);

            var book = new Book("Math Book"); 
            book.AddGrade(89.1);
            book.AddGrade(75.9);

            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;


            double result =0;    
           foreach(var grade in grades){
               highGrade =Math.Max(highGrade,grade);
               lowGrade =Math.Min(lowGrade,grade);
               result += grade;
           }

           var avg = result/(grades.Count);

            Console.WriteLine($"The result is: {result}");
            //formatting floating point numbers
            Console.WriteLine($"The highest grade is: {highGrade:N2}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N2}");
            Console.WriteLine($"The average grade is: {avg:N2}");

        }
    }
}
