using System;

namespace gradebook2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            var x=22.5; //using var (implictily typed) requires intialization
            double y=17.8;
            numbers[0] =x;
            numbers[1] =y;
            numbers[2] =42.2;

            double result;
            result = numbers[0] + numbers[1] + numbers[2];
//            for(int i =0; i<numbers.GetLength; i++)


            Console.WriteLine($"The result is: {result}");

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
