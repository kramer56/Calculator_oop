namespace calculator_oop
{
    public class Multiplicator : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber,double secondNumber)

        {
            return firstNumber * secondNumber;
        }
    }
}