namespace Dive_into_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = Dived2Numbers(2, 1);
            Console.WriteLine(res);
        }

        static int Dived2Numbers(int a, int b)
        {
            int result = a / b;
            return result;
        }

    }
}
