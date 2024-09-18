using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar7._2
{
    internal class ClassWithEvents
    {
        public event MyEventHandler SomeEvent;

        protected void OnSomeEvent(MyEventArgs args)
        {
            SomeEvent?.Invoke(this, args);
        }

        public void DoSomeWork()
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                OnSomeEvent(new MyEventArgs { Message = "End"});
            }).Start();
        }
    }

}
