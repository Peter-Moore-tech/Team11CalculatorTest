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
        public void OverloadAdd_Accumulator0Add5_Accumulator5()
        {
            //arrange

            //act
            uut.Add(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));

        }

        [Test]
        public void OverloadAdd_Accumulator10Add5_Accumulator15()
        {
            //arrange
            uut.Add(5, 5);
            //act
            uut.Add(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(15));

        }

        [Test]
        public void OverloadSubtract_Accumulator0Subtract5_AccumulatorMinus5()
        {
            //arrange

            //act
            uut.Subtract(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(-5));
        }

        [Test]
        public void OverloadSubtract_Accumulator10Subtract5_Accumulator5()
        {
            //arrange
            uut.Add(5, 5);
            //act
            uut.Subtract(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void OverloadMultiply_Accumulator0Multiply5_Accumulator0()
        {
            //arrange

            //act
            uut.Multiply(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void OverloadMultiply_Accumulator5Multiply5_Accumulator25()
        {
            //arrange
            uut.Add(5);
            //act
            uut.Multiply(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(25));
        }

        [Test]
        public void OverloadPower_Accumulator0Power5_Accumulator0()
        {
            //arrange

            //act
            uut.Power(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void OverloadDevide_Accumulator5Devide0_ExceptionThrown()
        {
            //arrange
            uut.Add(5);
            //act
            //assert
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void OverloadDevide_Accumulator0Devide5_Accumulator0()
        {
            //arrange
            
            //act
            uut.Divide(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void OverloadDevide_Accumulator25Devide5_Accumulator5()
        {
            //arrange
            uut.Add(25);
            //act
            uut.Divide(5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void OverloadPower_Accumulator5Power2_Accumulator25()
        {
            //arrange

            //act
            uut.Power(2);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(25));
        }

        [Test]
        public void Accumulator_MultiplyfiveTimesFive_Accumulator25()
        {
            //arrange

            //act
            uut.Multiply(5, 5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(25));

        }
        [Test]
        public void Accumulator_MultiplyfiveTimesFiveThenAddFivePlusFive_Accumulator10()
        {
            //arrange

            //act
            uut.Multiply(5, 5);
            uut.Add(5, 5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(10));

        }

        [Test]
        public void InitialAccumulator_NoAct_Accumulator0()
        {
            //arrange

            //act
            
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));

        }

        [Test]
        public void ClearAccumulator_MultiplyfiveTimesFiveThenClearAccumulator_Accumulator0()
        {
            //arrange

            //act
            uut.Multiply(5, 5);
            uut.Clear();
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));

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
        public void Power_fiveToThePowerOfFive_Res3125()
        {
            //arrange

            //act

            //assert
            Assert.That(uut.Power(5, 5), Is.EqualTo(3125));

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