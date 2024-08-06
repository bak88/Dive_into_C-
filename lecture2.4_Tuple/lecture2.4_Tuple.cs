namespace lecture2._4_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, string) tupleDef = (23, "Jack");
            (int age, string name) tupleAgeName = (30, "Jon");

            Console.WriteLine($"age={tupleDef.Item1}, name={tupleDef.Item2}");
            Console.WriteLine($"age={tupleAgeName.age}, name={tupleAgeName.name}");

            Console.WriteLine(tupleDef == tupleAgeName);
        }
    }
}
