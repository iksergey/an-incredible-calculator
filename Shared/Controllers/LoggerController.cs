using CalculatorCore.Logger;

namespace CalculatorCore.Controllers
{
    public class LoggerController : BaseController
    {
        BaseController bc;
        ILogger log;

        public LoggerController(BaseController controller, ILogger log = null)
        {
            bc = controller;
            this.log = log;
        }

        public override void ButtonClick()
        {
            log.Log($"Кнопка была нажата в {DateTime.Now}");
            bc.ButtonClick();
        }
    }
}
