using System;
using System.Collections.Generic;

namespace FizzBuzzComplex
{
    public class FizzBuzz
    {
        public FizzBuzz(int start = 1, int end = 100, int divisor1 = 3, int divisor2 = 5, string formula1Word = "Fizz", string formula2Word = "Buzz")
        {
            Start = start;
            End = end;
            Formula1Word = formula1Word;
            Formula2Word = formula2Word;
            Formula1 = i => i % divisor1 == 0;
            Formula2 = i => i % divisor2 == 0;
            Results = BuildList();
        }

        public FizzBuzz(Func<int, bool> formula1, Func<int, bool> formula2, int start = 1, int end = 100, string formula1Word = "Fizz", string formula2Word = "Buzz") 
        {
            Start = start;
            End = end;
            Formula1Word = formula1Word;
            Formula2Word = formula2Word;
            Formula1 = formula1;
            Formula2 = formula2;
            Results = BuildList();
        }

        public int Start { get; private set; }
        public int End { get; private set; }
        public static Func<int, bool> Formula1 { get; private set; }
        public static Func<int, bool> Formula2 { get; private set; }
        public string Formula1Word { get; private set; }
        public string Formula2Word { get; private set; }
        public List<string> Results { get; private set; }

        private List<string> BuildList()
        {
            var results = new List<string>();
            for (var i = Start; i <= End; i++)
                results.Add(FizzOrBuzz(i));

            return results;
        }

        public string FizzOrBuzz(int i)
        {
            var value = "";
            if (Formula1(i)) value += Formula1Word;
            if (Formula2(i)) value += Formula2Word;
            return value == "" ? "" + i : value;
        }
    }
}
