using calculator_oop;
using NUnit.Framework;

namespace caculator_oop.Tests.OneArgsClasses
{
    [TestFixture]
    public class ExtractionTests
    {
        [Test]
        public void CalculateTest()
        {
            Extraction calculator = new Extraction();
            Assert.AreEqual(0, calculator.calculate(0));
            Assert.AreEqual(1, calculator.calculate(1));
            Assert.AreEqual(5, calculator.calculate(25));
        }

    }
}
