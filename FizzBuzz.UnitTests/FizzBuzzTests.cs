using NUnit.Framework;
using System;

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

            Assert.AreEqual(output[2], App.Constants.Fizz);
            Assert.AreEqual(output[5], App.Constants.Fizz);
            Assert.AreEqual(output[8], App.Constants.Fizz);
        }

        [Test]
        public void ShouldOutputBuzzForNumbersDivisibleBy5()
        {
            var output = _fizzBuzz.Calculate(10);

            Assert.AreEqual(output[4], App.Constants.Buzz);
            Assert.AreEqual(output[9], App.Constants.Buzz);
        }

        [Test]
        public void ShouldOutputFizzBuzzForNumbersDivisibleByBoth3And5()
        {
            var output = _fizzBuzz.Calculate(15);

            Assert.AreEqual(output[14], App.Constants.FizzBuzz);
        }

        [Test]
        public void ShouldHandleInvalidInput()
        {
            Assert.Throws<InvalidOperationException>(() => _fizzBuzz.Calculate(-2));
            Assert.Throws<InvalidOperationException>(() => _fizzBuzz.Calculate(-0));
        }
    }
}
