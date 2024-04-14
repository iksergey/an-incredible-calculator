namespace CalculatorCore.Logger
{
    public class FileLog : ILogger
    {
        public void Log(string info)
        {
            File.AppendAllText("log.db", $"{info}{Environment.NewLine}");
        }
    }
}