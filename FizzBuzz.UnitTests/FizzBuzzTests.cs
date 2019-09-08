using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ShouldOutputFizzForNumbersDivisibleBy3()
        {
            var fizzBuzz = new App.FizzBuzz();

            var output = fizzBuzz.Calculate(9);

            Assert.AreEqual(output[2], "Fizz");
            Assert.AreEqual(output[5], "Fizz");
            Assert.AreEqual(output[8], "Fizz");
        }

        [Test]
        public void ShouldOutputBuzzForNumbersDivisibleBy5()
        {
            var fizzBuzz = new App.FizzBuzz();

            var output = fizzBuzz.Calculate(10);

            Assert.AreEqual(output[4], "Buzz");
            Assert.AreEqual(output[9], "Buzz");
        }

        [Test]
        public void ShouldOutputFizzBuzzForNumbersDivisibleByBoth3And5()
        {
            var fizzBuzz = new App.FizzBuzz();

            var output = fizzBuzz.Calculate(15);

            Assert.AreEqual(output[14], "FizzBuzz");
        }
    }
}
