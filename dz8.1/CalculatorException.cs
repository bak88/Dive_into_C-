using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8._1
{
    internal class CalculatorException : Exception
    {
        public Stack<CalculatorActionLog> calculatorActionLogs {  get; private set; } 
        public CalculatorException(string? message, Stack<CalculatorActionLog> calculatorActionLogs) : base(message)
        {
            this.calculatorActionLogs = calculatorActionLogs;
        }

        public CalculatorException(string message, Exception ex) : base(message)
        {

        }

        public override string ToString()
        {
            return Message + ", " + string.Join("\n", calculatorActionLogs.Select(x  => $"{x.CalculatorAction}, {x.CalculatorArgument}"));
        }

    }


}
