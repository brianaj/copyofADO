﻿using System;
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
            book.AddGrade(65.3);
            book.AddGrade(40.6);
            book.AddGrade(95);
            book.showStats();

        }
    }
}
