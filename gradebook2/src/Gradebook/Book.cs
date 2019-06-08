using System;
using System.Collections.Generic;

namespace Gradebook{

    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }

    }

    public abstract class Book :NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStats();
    }

    public interface IBook{
        void AddGrade(double grade);
        Statistics GetStats();
        string Name{ get;}
        event GradeAddedDelegate GradeAdded;

    }

    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class InMemoryBook : Book
    {
        List<double> grades;
        //readonly can only be modified during the inialization and in constructors
       // readonly string Category = "Science";

        //const is equivalent to final static keyword
         const string SUBJECT = "Science";
         public override event GradeAddedDelegate GradeAdded;


        public InMemoryBook(string name): base(name)
        {
            grades = new List<double>();
            Name = name;
        }
        //override keyword must be used to implement abstract class methods
        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0){
                grades.Add(grade);
                if (GradeAdded!= null)
                {
                    GradeAdded(this, new EventArgs());
                }
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
        public override Statistics GetStats()
        {
           Statistics stats = new Statistics();

           foreach(var grade in grades){
               stats.Add(grade);
           }

           return stats;
        }
    }
}