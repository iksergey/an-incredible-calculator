namespace CalculatorCore.Infrastructure
{
    public class Subtracting : IArithmetic
    {
        public double Result(double x, double y)
        {
            return x - y;
        }
    }
}
