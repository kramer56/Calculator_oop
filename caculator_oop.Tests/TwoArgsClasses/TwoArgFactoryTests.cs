using System;
using calculator_oop;
using NUnit.Framework;


namespace caculator_oop.Tests.TwoArgsClasses
{
    [TestFixture]
    public class TwoArgFactoryTests
    {
        [Test]
        [TestCase("summary", typeof(Additioner))]
        [TestCase("subtraction", typeof(Subtrackter))]
        [TestCase("multiplication", typeof(Multiplicator))]
        [TestCase("divisiont", typeof(Divisioner))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
