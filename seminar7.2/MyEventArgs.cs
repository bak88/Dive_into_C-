using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar7._2
{
    public class MyEventArgs : EventArgs
    {
        public string Message { get; init; }
    }

    public delegate void MyEventHandler(object sender, MyEventArgs args);
}
