using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace lecture7._1
{
    delegate void MyDelegate();

    delegate TRes MyGenericDel<T, TRes>(T x);

    delegate TResult MyFunc<out TResult>();

    delegate void MyAction<in T>(T x);

    delegate void MyAction2<T>(T x);



    internal class Program
    {
        static void SayHi(string name)
        {
            Console.WriteLine($"Hello Im {name}");
        }

        static string DigitToRoman(int digit)
        {
            switch (digit)
            {
                case 1: return "|";
                case 2: return "||";
                case 3: return "|||";
                case 4: return "|V";
                case 5: return "V";
                default: return "";
            }

        }

        static void SomeMethodObj(object o)
        {
            Console.WriteLine(o.GetType());
        }

        static void SomeMethodStr(string s)
        {
            Console.WriteLine(s.Length);
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static void AnotherMethod(Action method)
        {
            method();
        }

        static Action GetAction()
        {
            int i = 0;
            return () => Console.WriteLine(++i);
        }
        static void Main(string[] args)
        {
            Action<string> action = (_) => Console.WriteLine("hi");

            action += (string name) => Console.WriteLine($" {name}");

            var func = object () => "lol";



        }

    }
}
