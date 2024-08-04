namespace lecture2._2_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"red={(int)Color.Red}, white={(int)Color.White}");

            Color greenAndWhite = Color.White | Color.Green;
            Console.WriteLine((int)greenAndWhite);
        }

    }

    [Flags] // атрибут Flags может комбинировать значения
            // при условии, что их биты не пересикаются
    enum Color : byte
    {
        Red,
        Green=3,
        White = 6
    }
}
