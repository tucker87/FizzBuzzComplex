using System;

namespace FizzBuzzComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz(
                fizz => fizz % 3 == 0, 
                buzz => buzz % 5 == 0);

            foreach (var result in fb.Results)
                Console.WriteLine(result);
        }
    }
}
