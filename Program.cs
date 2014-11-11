using System;

namespace FizzBuzzComplex
{
    class Program
    {
        static void Main()
        {
            var fb = new FizzBuzz(
                fizz => true, 
                buzz => buzz % 2 == 0);
            foreach (var result in fb.Results)
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
