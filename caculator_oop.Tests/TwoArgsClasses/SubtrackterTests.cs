using calculator_oop;
using NUnit.Framework;



namespace caculator_oop.Tests.TwoArgsClasses
{
    [TestFixture]
   public class SubtrackterTests
    {
        [Test]
        public void calculateTest()
        {
            Additioner calculator = new Additioner();
            Assert.AreEqual(0, calculator.calculate(6, 6));
            Assert.AreEqual(10, calculator.calculate(15, 5));
            Assert.AreEqual(0.25, calculator.calculate(0.75, 0.25));
        }
    }
}
