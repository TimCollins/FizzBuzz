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
    }
}
