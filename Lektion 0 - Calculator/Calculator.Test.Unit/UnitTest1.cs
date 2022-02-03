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
    }
}