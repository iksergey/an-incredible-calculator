﻿using CalculatorCore.Infrastructure;

namespace CalculatorCore.Models
{
    public class Model : IModel
    {
        private readonly IArithmetic arithmetic;
        public Model(IArithmetic arithmetic) => this.arithmetic = arithmetic;
        public double Execute(double x, double y) => arithmetic.Result(x, y);
    }
}
