using System;
using System.Collections.Generic;

namespace gradebook2{
    class Book
    {
        List<double> grades;
        string name;

        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStats()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            double result =0;    
           foreach(var grade in grades){
               highGrade =Math.Max(highGrade,grade);
               lowGrade =Math.Min(lowGrade,grade);
               result += grade;
           }

           var avg = result/(grades.Count);
           //formatting floating point numbers
            Console.WriteLine($"The highest grade is: {highGrade:N2}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N2}");
            Console.WriteLine($"The average grade is: {avg:N2}");
        }
    }
}