using System;

namespace gradebook2
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var (implictily typed) requires intialization
            var numbers = new []{22.5, 42.2, 17.8};

            double result =0;
            
           foreach(var num in numbers){
               result += num;
           }


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
