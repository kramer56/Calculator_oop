using System;
using calculator_oop;
using NUnit.Framework;

namespace caculator_oop.Tests.OneArgsClasses
{
    [TestFixture]
    public class OneArgFactory
    {
        [Test]
        [TestCase("sqrt", typeof(Extraction))]
        [TestCase("exp", typeof(Exp))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
