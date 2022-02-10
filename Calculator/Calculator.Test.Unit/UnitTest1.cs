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
        public void OverloadAdd_Accumulator10AddMinus5_Accumulator5()
        {
            //arrange
            uut.Add(5, 5);
            //act
            uut.Add(-5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
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
        public void OverloadSubtract_Accumulator10SubtractMinus5_Accumulator15()
        {
            //arrange
            uut.Add(5, 5);
            //act
            uut.Subtract(-5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(15));
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
        public void OverloadMultiply_Accumulator5MultiplyMinus5_AccumulatorMinus25()
        {
            //arrange
            uut.Add(5);
            //act
            uut.Multiply(-5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(-25));
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
        public void OverloadPower_Accumulator5Power2_Accumulator25()
        {
            //arrange
            uut.Add(5);
            //act
            uut.Power(2);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(25));
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
        public void OverloadDevide_Accumulator25DevideMinus5_AccumulatorMinus5()
        {
            //arrange
            uut.Add(25);
            //act
            uut.Divide(-5);
            //assert
            Assert.That(uut.Accumulator, Is.EqualTo(-5));
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
        public void Add_TwoPlusFour_Accumulator6()
        {
            //Act
            uut.Add(2, 4);
            // ASSERT 
            Assert.That(uut.Accumulator,Is.EqualTo(6));
        }

        [Test]
        public void Add_MinusTwoPlusMinusThree_AccumulatorMinus5()
        {
            //Act
            uut.Add(-2, -3);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(-5));
        }
        
        [Test]
        public void Add_TwoPlusMinusThree_AccumulatorMinus1()
        {
            //Act
            uut.Add(2, -3);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(-1));
        }


        [Test]
        public void Multiply_MinusTwoTimesThree_AccumulatorMinus6()
        {
            //ACT
            uut.Multiply(-2, 3);
            // ACT and ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(-6));
        }

        [Test]
        public void Multiply_MinusTwoTimesMinusThree_Accumulator6()
        {
            //ACT
            uut.Multiply(-2, -3);
            // ACT and ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_TwoTimesFive_Accumulator10()
        {
            //ACT
            uut.Multiply(2, 5);
            // ACT and ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(10));
        }

        [Test]
        public void Subtract_FiveMinusFive_Accumulator0()
        {
            // ACT
            uut.Subtract(5, 5);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Subtract_FiveMinusMinusFive_Accumulator10()
        {
            // ACT
            uut.Subtract(5, -5);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(10));
        }


        [Test]
        public void Subtract_MinusFiveMinusMinusFive_Accumulator0()
        {
            // ACT
            uut.Subtract(-5, -5);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(2,0,1)]
        [TestCase(-1, 2, 1)]
        [TestCase(-1, 3, -1)]
        [TestCase(0, 1, 0)]
        [TestCase(5, -1, 0.2)]

        public void Power_SeveralTestCases(double a, double b, double result)
        {
            //arrange

            //act

            //assert
            Assert.That(uut.Power(a, b), Is.EqualTo(result));

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
        public void Divide_FiveDividedByFive_Accumulator1()
        {
            // ACT
            uut.Divide(5, 5);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(1));
        }

        [Test]
        public void Divide_TenDividedByMinusFive_AccumulatorMinusTwo()
        {
            // ACT
            uut.Divide(10, -5);
            // ASSERT 
            Assert.That(uut.Accumulator, Is.EqualTo(-2));
        }


        [Test]
        public void Divide_DivideByZero_ExceptionThrown()
        {
            // ACT and ASSERT 
            Assert.That(() => uut.Divide(5, 0), Throws.TypeOf<DivideByZeroException>());

        }
    }
}