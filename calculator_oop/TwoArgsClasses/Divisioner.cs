using System;

namespace calculator_oop
{
    public class Divisioner : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber,double secondNumber)

        {
            if (secondNumber == 0)
            { 
                throw new Exception("Деление на ноль запрещено!");
            }
            return firstNumber / secondNumber;
        }
    }
}