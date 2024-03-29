﻿using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var (implictily typed) requires intialization
            var book = new Book("Math Book"); 

            string input;
            Console.WriteLine("Enter a grade or q to quit: ");
            input = Console.ReadLine();

            while (!input.Equals("q")){
                try{
                    double inputeGrade = double.Parse(input);
                    Console.WriteLine("Your input: {0}",inputeGrade);
                    book.AddGrade(inputeGrade);
                }catch(FormatException ex){
                    Console.WriteLine(ex.Message);
                }catch(ArgumentException ex){
                    Console.WriteLine(ex.Message);
                }catch(Exception ex){
                    Console.WriteLine(ex.Message);
                    throw;
                }


                Console.WriteLine("Enter a grade or q to quit: ");
                input = Console.ReadLine();
            }
        
            var stats = book.GetStats();
            Console.WriteLine($"The highest grade is: {stats.High:N2}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The average grade is: {stats.Average:N2}");
            Console.WriteLine($"The average letter grade is: {stats.LetterGrade}");


        }
    }
}
