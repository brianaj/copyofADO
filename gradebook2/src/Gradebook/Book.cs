using System;
using System.Collections.Generic;

namespace gradebook2{
    class Book
    {
        List<double> grades;

        public Book(){
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}