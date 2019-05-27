using System;

namespace gradebook2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x=22.5; //using var (implictily typed) requires intialization
            double y=17.8;
            var result = x+y;

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
