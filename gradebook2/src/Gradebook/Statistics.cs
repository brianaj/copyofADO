using System;

namespace Gradebook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Result / Count;

            }
        }
        public double High;
        public double Low;

        public double Result;

        public char LetterGrade
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';

                }
            }
        }
        public int Count;

        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Result = 0.0;
            Count = 0;
        }

        public void Add(double number)
        {
            Result += number;
            Count++;
            High = Math.Max(High, number);
            Low = Math.Min(Low, number);
        }
    }
}