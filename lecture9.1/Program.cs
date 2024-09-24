namespace lecture9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new object();

            Type typeObj = obj.GetType();
            Type typeClass = typeof(object);
            Console.WriteLine(typeObj == typeClass);
        }
    }
}
