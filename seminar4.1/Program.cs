namespace seminar4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits bits = new(4);

            //Console.WriteLine(bits.GetBit(2));
            //bits.SetBit(0, true);
            //Console.WriteLine(bits.GetBit(0));

            //bits[1] = true;
            //Console.WriteLine(bits[1]);
            //Console.WriteLine(bits.Value);

            Console.WriteLine(bits.GetType());
            byte val = bits;
            Console.WriteLine(val.GetType());
            bits = new(val);
            Console.WriteLine(bits.GetType());
        }
    }
}
