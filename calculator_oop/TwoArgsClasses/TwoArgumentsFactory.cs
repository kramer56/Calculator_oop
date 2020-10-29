using System;
namespace calculator_oop
{
    public static class TwoArgumentsFactory
    {

        public static ITwoArgumentsCalculator CreateCalculator(String name)
        {
            switch(name)
            {
                case "summary": return new Additioner();
                case "subtraction": return new Subtrackter();
                case "multiplication": return new Multiplicator();
                case "division": return new Divisioner();
                default: throw new Exception("Неизвестная операция");
            }
          
        }
    }
}
