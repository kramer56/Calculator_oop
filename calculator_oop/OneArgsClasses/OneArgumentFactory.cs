using System;
namespace calculator_oop
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(String name)
        {
            switch (name)
            {
                case "sqrt": return new Extraction();
                case "exp": return new Exp();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
