using lecture4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    abstract class Person : IComparable, IParent, IFamily
    {
        readonly string Name = string.Empty;
        readonly DateTime BirthDay;
        readonly int Height;
        public Person Father = null;
        public Person Mother = null;
        public Person[] Children = null;
        protected abstract string HiPhrase { get; set; }

        public Person[] Family;
        public int Count => 1 + (Family?.Length ?? 0);

        public Person this[int index]
        {
            get
            {
                if (index <= 0) return this;
                if (Family is null) return null;
                if (Family.Length >= index) return Family[index - 1];
                return null;
            }
        }

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

            int familyCount = 0;
            familyCount += Father == null ? 0 : 1;
            familyCount += Mother == null ? 0 : 1;
            familyCount += Children.Length;

            if (familyCount > 0)
            {
                Family = new Person[familyCount];
            }
            else
            {
                return;
            }

            int counter = 0;

            if (Father != null)
            {
                Family[counter] = Father;
                counter++;
            }
            if (Mother != null)
            {
                Family[counter] = Mother;
                counter++;
            }
            foreach (var item in children)
            {
                Family[counter] = item;
                counter++;

            }

        }

        public virtual void SayHiPhrase()
        {
            Console.WriteLine(HiPhrase);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
                return -1;
            return this.BirthDay.CompareTo((obj as Person).BirthDay);
        }

        public bool GetChildren(out Person[] children)
        {
            if (Children != null && Children.Length > 0)
            {
                children = Children;
                return true;
            }
            else
            {
                children = null;
                return true;
            }
        }
        public abstract void TakeCareImplementation();
        public void TakeCare()
        {
            if (Children != null)
            {
                TakeCareImplementation();
            }
        }
    }
}
