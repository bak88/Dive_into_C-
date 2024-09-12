using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test1._1
{
    internal class Company
    {
        Person[] personal;
        public Company(Person[] person)
        {
            this.personal = person;
        }

        public Person this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }
}
