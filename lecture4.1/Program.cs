using lecture4._1;
using System;
using System.Security.Cryptography.X509Certificates;

namespace lecture4._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ICovariant<string> str = new SomeClass<string>();
            ICovariant<object> obj = str;
            
            ICovariant<object> obj2 = new SomeClass<string>(); ;
            
            // ICovariant<string> str2 = obj2;
        }
    }

    interface ICovariant<out T>
    {
        T GetDefault();
    }

    class SomeClass<T> : ICovariant<T>
    {
        public T GetDefault()
        {
            return default;
        }
    }



}
