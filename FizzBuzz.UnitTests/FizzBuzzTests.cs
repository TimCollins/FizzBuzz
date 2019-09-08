using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private App.FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new App.FizzBuzz();
        }

        [Test]
        public void ShouldOutputFizzForNumbersDivisibleBy3()
        {
            var output = _fizzBuzz.Calculate(9);

            Assert.AreEqual(output[2], "Fizz");
            Assert.AreEqual(output[5], "Fizz");
            Assert.AreEqual(output[8], "Fizz");
        }

        [Test]
        public void ShouldOutputBuzzForNumbersDivisibleBy5()
        {
            var output = _fizzBuzz.Calculate(10);

            Assert.AreEqual(output[4], "Buzz");
            Assert.AreEqual(output[9], "Buzz");
        }

        [Test]
        public void ShouldOutputFizzBuzzForNumbersDivisibleByBoth3And5()
        {
            var output = _fizzBuzz.Calculate(15);

            Assert.AreEqual(output[14], "FizzBuzz");
        }

    }
}
