using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lecture4._1
{
    internal class Man : Person
    {
        public bool HasBeard { get; private set; } = false;
        protected override string HiPhrase { get; set; } = "Hi, Im is a Man";
        public Man(string name) : base(name)
        {

        }
        public Man(string name, DateTime birthday) : base(name, birthday)
        {

        }

        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = true;
        }

        public override void SayHiPhrase()
        {
            Console.WriteLine(HiPhrase);
        }

        public new void Print()
        {
            Console.WriteLine("!!!");
        }

        public override void TakeCareImplementation()
        {
            Console.WriteLine("Проверяем уроки");
        }
    }
}
