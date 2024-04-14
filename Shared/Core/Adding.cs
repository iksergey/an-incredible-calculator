namespace CalculatorCore.Infrastructure
{
    public class Adding : IArithmetic
    {
        public double Result(double x, double y)
        {
            return x + y;
        }
    }
}
