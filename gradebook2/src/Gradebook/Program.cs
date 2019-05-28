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


            double result =0;    
           foreach(var grade in grades){
               result += grade;
           }

           var avg = result/(grades.Count);

            Console.WriteLine($"The result is: {result}");
            //formatting floating point numbers
            Console.WriteLine($"The average grade is: {avg:N2}");

        }
    }
}
