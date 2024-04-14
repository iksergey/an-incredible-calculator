using CalculatorCore.Infrastructure;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace CalculatorCore.Controllers
{
    public class BaseController
    {
        public virtual IView View { get; set; }
        public virtual IModel Model { get; set; }
        public virtual INumberConverter Converter { get; set; }
        public virtual void ButtonClick() { }
    }
}
