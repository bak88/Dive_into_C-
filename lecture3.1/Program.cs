using System;
using System.Security.Cryptography.X509Certificates;

namespace lecture3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var woman = new Woman("Hanna", DateTime.Parse("25.08.1990"));
            var man = new Man("Jack", DateTime.Parse("15.05.1989"));

            Person[] people = new Person[] { man, woman };

            foreach (var person in people)
            {
                person.SayHiPhrase();

            }

        }
    }



    class SomeClass
    {
        private readonly int num;

        public SomeClass(int num)
        {
            this.num = num;
        }

        public int pow2 { get { return num * num; } }
        public int pow3 { get { return num * num * num; } }
        public int pow4 { get { return num * num * num * num; } }
    }
}
