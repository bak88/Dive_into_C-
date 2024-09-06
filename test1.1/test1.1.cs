namespace test1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = null;

            obj = 1;

            Console.WriteLine(obj.GetType());

            int a = (int)obj;

            Console.WriteLine(a.GetType());

            Console.WriteLine(sizeof(int));

        }
    }
}
