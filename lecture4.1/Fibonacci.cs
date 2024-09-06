using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    internal class Fibonacci
    {
        public int Value { get; private set; } = 1;
        int valuePrev = 0;

        public static Fibonacci operator ++(Fibonacci fibonacci )
        {
            var temp = fibonacci.Value;
            fibonacci.Value = fibonacci.Value + fibonacci.valuePrev;
            fibonacci.valuePrev = temp;
            return fibonacci;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
