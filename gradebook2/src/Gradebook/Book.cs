using System;
using System.Collections.Generic;

namespace Gradebook{
    public class Book
    {
        List<double> grades;
        public string Name{
            get{
                return name;
            }
            set{
                if(!string.IsNullOrEmpty(value)){
                    name = value;
                }
            }
        }

        private string name;

        public Book(string name){
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0){
                grades.Add(grade);
            }
            else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            
        }

        public void AddGrade(char letterGrade){
            switch(letterGrade)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70); 
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    AddGrade(50);
                    break;
                default:
                    AddGrade(0);
                    break;
            }

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

           
           switch(avg)
           {
            case var d when d >= 90.0:
                stats.LetterGrade = 'A';
                break;
            case var d when d >= 80.0:
                stats.LetterGrade = 'B';
                break;
            case var d when d >= 70.0:
                stats.LetterGrade = 'C';
                break;
            case var d when d >= 60.0:
                stats.LetterGrade = 'D';
                break;
            default:
                stats.LetterGrade = 'C';
                break;
           }

           return stats;
        }
    }
}