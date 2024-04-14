namespace CalculatorCore.Infrastructure
{
    public class Multiplication : IArithmetic
    {
        public double Result(double x, double y)
        {
            return x * y;
        }
    }
}
