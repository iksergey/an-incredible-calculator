namespace CalculatorCore.Infrastructure
{
    public interface INumberConverter
    {
        double Convert(string value);
        string ConvertBack(double value);
    }
}
