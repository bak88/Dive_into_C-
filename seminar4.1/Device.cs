using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal class Device : IControllable
    {
        public bool IsOn {  get; private set; } = false;
        public void Off()
        {
            IsOn = false;            
        }

        public void On()
        {
            IsOn = true;            
        }
    }
}
