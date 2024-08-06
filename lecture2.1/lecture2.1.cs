internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        int b = a;
        a = 20;
        Console.WriteLine($"a={a}, b={b}");

        SomeClass sc1 = new SomeClass();
        sc1.someVariable = 10;

        SomeClass sc2 = sc1;
        sc2.someVariable = 20;

        Console.WriteLine($"sc1={sc1.someVariable}, sc2={sc2.someVariable}");

        int c = 256;

        checked
        {
        byte d = (byte)c;
        Console.WriteLine(d);

        }


    }

    class SomeClass
    {
        public int someVariable;
    }

    
}
