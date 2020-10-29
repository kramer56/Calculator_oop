using calculator_oop;
using NUnit.Framework;


namespace caculator_oop.Tests.TwoArgsClasses
{
    [TestFixture]
   public class DivisionerTests
    {
        [Test]
        public void calculateTest()
        {
            Divisioner calculator = new Divisioner();
            Assert.AreEqual(10, calculator.calculate(50, 5));
            Assert.AreEqual(5, calculator.calculate(25, 5));
            Assert.AreEqual(0.25, calculator.calculate(0.5, 2));
        }
    }
}
