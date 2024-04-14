namespace CalculatorCore.Infrastructure
{
    public class Division : IArithmetic
    {
        public double Result(double x, double y)
        {
            return x / y;
        }
    }
}
