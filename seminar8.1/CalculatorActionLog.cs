using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar8._1
{
    internal class CalculatorActionLog
    {
        public CalculatorAction CalculatorAction { get; private set; }
        public int CalculatorArgument {  get; private set; }

        public CalculatorActionLog(CalculatorAction calculatorAction, int calculatorArgument )
        {
            this.CalculatorAction = calculatorAction;
            this.CalculatorArgument = calculatorArgument;
        }
    }
}
