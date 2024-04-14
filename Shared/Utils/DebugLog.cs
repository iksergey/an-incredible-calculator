using System.Diagnostics;

namespace CalculatorCore.Logger
{
    public class DebugLog : ILogger
    {
        public void Log(string info)
        {
            Debug.WriteLine($"{info}{Environment.NewLine}");
        }
    }
}