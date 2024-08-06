namespace lecture2._5_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj1 = new object();
            object obj2 = new object();

            Console.WriteLine(obj1.Equals(obj2));

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine(obj1.GetType());

            Console.WriteLine(obj2.ToString());


        }
    }
}
