using calculator_oop;
using NUnit.Framework;
namespace caculator_oop.Tests.TwoArgsClasses
{
    public class MultiplicatorAdvansedTests
    {
        [TestFixture]
        public class MultiplyCalculatorAdvancedTests
        {
            [Test]
            [TestCase(0, 0, 0)]
            [TestCase(5, 2, 10)]
            [TestCase(10, 99, 990)]
            [TestCase(1.75, 5.45, 9.5375)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                Multiplicator calculator = new Multiplicator();
                var actualResult = calculator.calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }
}
