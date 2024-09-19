using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar7._1
{
    internal interface ICalculator
    {
        event EventHandler<EventArgs> GotResult;
        void Sum(int x);
        void Subtract(int x);
        void Multiply(int x);
        void Divide(int x);

        void CancelLast();

    }
}
