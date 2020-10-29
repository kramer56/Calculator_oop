using calculator_oop;
using NUnit.Framework;


namespace caculator_oop.Tests.TwoArgsClasses
{
    [TestFixture]
    public class AdditionerTests
    {
        [Test]
        public void calculateTest()
        {
            Additioner calculator = new Additioner();
            Assert.AreEqual(10, calculator.calculate(6, 4));
            Assert.AreEqual(36, calculator.calculate(12, 24));
            Assert.AreEqual(5.9, calculator.calculate(5.2, 0.7));
        }

    }
}
