using CalculatorCore.Views;
using static System.Console;

namespace ConsoleUI
{
    class ConsoleView : ICli
    {
        public string FirstNumber
        {
            get
            {
                Write("Первое число: ");
                return ReadLine();
            }
        }

        public string SecondNumber
        {
            get
            {
                Write("Второе число: ");
                return ReadLine();
            }
        }

        public string Result
        {
            set
            {
                WriteLine($"Результат: {value}");
            }
        }

        public void WelcomeAction(string msg)
        {
            WriteLine("Привет!");
        }
    }
}
