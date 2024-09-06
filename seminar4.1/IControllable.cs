using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal interface IControllable
    {
        bool IsOn { get; }
        public void On();
        public void Off();
    }
}
