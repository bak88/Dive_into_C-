using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8._1
{
    internal class CalculatorActionLog
    {
        public CalculatorAction CalculatorAction { get; private set; }
        public double CalculatorArgument {  get; private set; }

        public CalculatorActionLog(CalculatorAction calculatorAction, double calculatorArgument )
        {
            this.CalculatorAction = calculatorAction;
            this.CalculatorArgument = calculatorArgument;
        }
    }
}
