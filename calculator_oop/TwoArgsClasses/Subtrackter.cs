namespace calculator_oop
{
    public class Subtrackter : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber) 
        { 
            return firstNumber - secondNumber; 
        }
    }
}