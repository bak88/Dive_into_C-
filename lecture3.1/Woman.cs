using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3._1
{
    internal class Woman : Person
    {
        public bool HasMakeup { get; private set; } = false;
        protected override string HiPhrase { get; set; } = "Hi, Im is a Woman";
        public Woman(string name) : base(name)
        {

        }
        public Woman(string name, DateTime birthday) : base(name, birthday)
        {

        }

        public void PutMakeupOn()
        {
            Console.WriteLine("Наносит макияж");
            this.HasMakeup = true;
        }

        public void RemoveMakeUp()
        {
            Console.WriteLine("Снимает макияж");
            this.HasMakeup = false;
        }
        public override void SayHiPhrase()
        {
            Console.WriteLine(HiPhrase);
        }
    }
}
