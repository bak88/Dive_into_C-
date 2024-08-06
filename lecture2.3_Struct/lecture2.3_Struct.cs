namespace lecture2._3_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Console.WriteLine($"x={point.x}, y={point.y}");
        }
    }

    struct Point
    {
        public float x; // default = 0
        public float y; // default = 0
    }
}
