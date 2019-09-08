using System;

namespace FizzBuzz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to output the first 100 numbers with Fizz, Buzz and FizzBuzz substitutions as appropriate
            // See https://en.wikipedia.org/wiki/Fizz_buzz

            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.Calculate(15);
            Display(output);

            Utils.WaitForEscape();
        }

        private static void Display(string[] output)
        {
            for (var i = 0; i < output.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i + 1, output[i]);
            }
        }
    }
}
