using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal interface IIndexable<T>
    {
        T this[int index] { get; set; }
    }
}
