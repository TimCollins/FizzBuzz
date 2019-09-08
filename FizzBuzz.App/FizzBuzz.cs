using System;

namespace FizzBuzz.App
{
    public class FizzBuzz
    {
        public string[] Calculate(int max)
        {
            if (max < 1)
            {
                throw new InvalidOperationException("Input must be greater than zero.");
            }

            var output = new string[max];

            for (var i = 0; i < max; i++)
            {
                output[i] = GetFizzBuzz(i + 1);
            }

            return output;
        }

        private string GetFizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString();
        }
    }
}
