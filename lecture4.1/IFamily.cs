using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    internal interface IFamily
    {
        Person this[int index] { get; }
        int Count { get; }
    }
}
