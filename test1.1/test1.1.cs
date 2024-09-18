namespace test1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, s = 0;

            for (int k = 1, l = 5; k <l; ++k, --l)
            {
                s += k;
            }
            Console.WriteLine(s);
        }
    }
}
