using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar8._1
{
    internal class Calculator : ICalculator
    {
        public int Result;

        public event EventHandler<EventArgs> GotResult;

        private Stack<int> stack = new Stack<int>();

        private Stack<CalculatorActionLog> actions = new Stack<CalculatorActionLog>();

        public void Divide(int x)
        {
            if ( x == 0)
            {
                actions.Push(new CalculatorActionLog(CalculatorAction.Divide, x));
                throw new CalculatorDivideByZeroException("Деление на 0 не возможно", actions);
            }

            stack.Push(Result);
            Result /= x;
            RaiseEvent();
            
        }

        public void Multiply(int x)
        {
            long temp = x * Result;

            if (temp > int.MaxValue )
            {
                actions.Push(new CalculatorActionLog(CalculatorAction.Multiply, x));
                throw new CalculateOperationCauseOverflowException("Переполнение стека", actions);
            }
            stack.Push(Result);
            Result *= x;
            RaiseEvent();
            
        }

        public void Subtract(int x)
        {
            long temp = Result - x;

            if (temp < int.MinValue)
            {
                actions.Push(new CalculatorActionLog(CalculatorAction.Subtract, x));
                throw new CalculateOperationCauseOverflowException("Переполнение стека", actions);
            }
            stack.Push(Result);
            Result -= x;
            RaiseEvent();
            
        }

        public void Sum(int x)
        {
            ulong temp = (ulong)(x + Result);

            if (temp > int.MaxValue)
            {
                actions.Push(new CalculatorActionLog(CalculatorAction.Sum, x));
                throw new CalculateOperationCauseOverflowException("Переполнение стека", actions);
            }
            stack.Push(Result);
            Result += x;
            RaiseEvent();
            
        }
        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                Result = stack.Pop();
                RaiseEvent();
            }
        }

        private void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }
    }
}
