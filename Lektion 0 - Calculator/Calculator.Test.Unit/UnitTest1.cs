using System;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private MyCalculator.Calculator uut;
        [SetUp]
        public void Setup()
        {
            // ARRANGE
            uut = new MyCalculator.Calculator();
        }

        [Test]
        public void Calculator_AddTwoPositiveIntegers_IntegersAdded()
        {
            // ASSERT 
            Assert.That(uut.Add(2,3),Is.EqualTo(5));
        }

        [Test]
        public void Calculator_MultiplyPosiviteAndNegativeInteger_IntegersMultiplied()
        {
            // ACT and ASSERT 
            Assert.That(uut.Multiply(-2, 3), Is.EqualTo(-6));
        }

        [Test]
        public void Calculator_Subtract_FiveMinusFive_Res0()
        {
            // ACT and ASSERT 
            Assert.That(uut.Subtract(5, 5), Is.EqualTo(0));
        }

        [Test]
        public void Divide_FiveDividedByFive_Res1()
        {
            // ACT and ASSERT 
            Assert.That(uut.Divide(5, 5), Is.EqualTo(1));
        }

        [Test]
        public void Divide_DivideByZero_ExceptionThrown()
        {
            // ACT and ASSERT 
            Assert.That(() => uut.Divide(5, 0), Throws.TypeOf<DivideByZeroException>());

        }
    }
}