using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar7._1
{
    internal class Calculator : ICalculator
    {
        public int Result;

        public event EventHandler<EventArgs> GotResult;

        private Stack<int> stack = new Stack<int>();

        public void Divide(int x)
        {
            stack.Push(Result);
            Result /= x;
            RaiseEvent();
            
        }

        public void Multiply(int x)
        {
            stack.Push(Result);
            Result *= x;
            RaiseEvent();
            
        }

        public void Subtract(int x)
        {
            stack.Push(Result);
            Result -= x;
            RaiseEvent();
            
        }

        public void Sum(int x)
        {
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
