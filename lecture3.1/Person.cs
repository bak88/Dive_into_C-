using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3._1
{
    abstract class Person
    {
        readonly string Name = string.Empty;
        readonly DateTime BirthDay;
        readonly int Height;
        public Person Father = null;
        public Person Mother = null;
        public Person[] Children = null;
        protected abstract string HiPhrase { get; set; } 

        public Person(string name, DateTime birthday)
        {
            this.Name = name;
           
            if (birthday > DateTime.Now)
            {
                Console.WriteLine($"birthday={birthday}, не может быть больше текущей даты {DateTime.Now.ToString("dd.MM.yyyy")}");
                this.BirthDay = DateTime.Now;
            }
            else
            {
                this.BirthDay = birthday;

            }
        }

        public Person(string name)
        {
            
            this.Name = name;
            this.BirthDay = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"name={Name}, birthday={BirthDay}");
        }

        public bool IsAdult(int age = 18)
        {
            var delta = DateTime.Now.Year - BirthDay.Year;

            if (delta > age || (delta == age && DateTime.Now.DayOfYear <= BirthDay.DayOfYear))
            {
                return true;
            }
            return false;
        }

        public void AddFamilyInfo(Person father, Person mother, params Person[] children)
        {
            this.Father = father;
            this.Mother = mother;
            this.Children = children;
        }

        public virtual void SayHiPhrase()
        {
            Console.WriteLine(HiPhrase);
        }
    }
}
