using CalculatorCore.Controllers;
using CalculatorCore.Infrastructure;
using CalculatorCore.Logger;
using CalculatorCore.Models;
using ConsoleUI;

var controller = new LoggerController(
            new ControllerBuilder()
                .SetView(new ConsoleView())
                .SetModel(new Model(new Adding()))
                .SetConvertor(new NumberConverter())
                .Build(),
            new DebugLog()
);

controller.ButtonClick();
