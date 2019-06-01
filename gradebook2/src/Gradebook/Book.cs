using System;
using System.Collections.Generic;

namespace Gradebook{
    public class Book
    {
        List<double> grades;
        public string Name;

        public Book(string name){
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStats()
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

           Statistics stats = new Statistics();
           stats.Average = avg;
           stats.High = highGrade;
           stats.Low = lowGrade;

           return stats;
        }
    }
}