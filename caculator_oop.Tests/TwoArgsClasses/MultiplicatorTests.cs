using calculator_oop;
using NUnit.Framework;


namespace caculator_oop.Tests.TwoArgsClasses
{

    [TestFixture]
   public class MultiplicatorTests
    {
        [Test]
        public void calculateTest()
        {
            Multiplicator calculator = new Multiplicator();
            Assert.AreEqual(10, calculator.calculate(2, 5));
            Assert.AreEqual(36, calculator.calculate(4, 9));
            Assert.AreEqual(0.75, calculator.calculate(0.25, 3));
        }
    }
}
