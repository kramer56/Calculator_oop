using System;

namespace calculator_oop
{
    public class Exp : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)

        {
            return Math.Exp(firstNumber);
        }
    }
}