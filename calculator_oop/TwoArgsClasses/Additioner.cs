namespace calculator_oop
{
    public class Additioner : ITwoArgumentsCalculator
    {

public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}