using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar8._1
{
    internal class CalculateOperationCauseOverflowException : CalculatorException
    {
        public CalculateOperationCauseOverflowException(string message, Stack<CalculatorActionLog> calculatorActionLogs) : base(message, calculatorActionLogs)
        {

        }

        public CalculateOperationCauseOverflowException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
