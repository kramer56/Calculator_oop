using calculator_oop;
using NUnit.Framework;

namespace caculator_oop.Tests.OneArgsClasses
{
    [TestFixture]
   public class ExpTests
    {
        [Test]
        public void CalculateTest()
        {
            Exp calculator = new Exp();
            Assert.AreEqual(2.71828182845905, calculator.calculate(1));
            Assert.AreEqual(1, calculator.calculate(0));
            Assert.AreEqual(7.38905609893065, calculator.calculate(2));
        }
    }
}
