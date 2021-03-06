using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
        public double Add(double addend)
        {
            return Accumulator += addend;
        }
        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }
        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return Accumulator /= divisor;
        }
        public double Power(double exponent)
        {
            return Accumulator =Math.Pow(Accumulator, exponent);
        }

        public double Add(double a, double b)
        {
            return Accumulator =a + b;
        }
        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }
        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }
        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            return Accumulator=dividend / divisor;
            
        }
    }
}
