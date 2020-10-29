using calculator_oop;
using NUnit.Framework;

namespace caculator_oop.Tests.TwoArgsClasses
{
    [TestFixture]
   public class DivisionerAdvansedTests
    {
        [Test]
        [TestCase(0, 10, 0)]
        [TestCase(5, 2, 2.5)]
        [TestCase(25, 25, 1)]
        [TestCase(66, 22, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            Divisioner calculator = new Divisioner();
            var actualResult = calculator.calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);

        }
    }
}
