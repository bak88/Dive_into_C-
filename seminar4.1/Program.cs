namespace seminar4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bits bits = new(4);
            //Console.WriteLine(bits.GetBit(2));
            //bits.SetBit(0, true);
            //Console.WriteLine(bits.GetBit(0));

            //bits[1] = true;
            //Console.WriteLine(bits[1]);
            //Console.WriteLine(bits.Value);





            Bits bits = new(4);
            Console.WriteLine(bits);
            long val = bits;
            Console.WriteLine(val);
            Bits bits2 = (Bits)val;






            //Devices devices = new Devices();
            //Bits bits = new Bits(63);

            //Console.WriteLine(devices);
            //devices.TurnOnOff(bits);
            //Console.WriteLine(devices);











            //Bits bitByte = new((byte)10);
            //Bits bitInt = new((int)10);
            //Bits bitLong = new((long)10);

            //Console.WriteLine(bitByte);
            //Console.WriteLine(bitInt);
            //Console.WriteLine(bitLong);

            //Collection<string> collection = new Collection<string>(10);
            //collection[0] = "1";
            //collection[1] = "2";

            //Console.WriteLine(collection[0]);
            //Console.WriteLine(collection[1]);











            Matrix<int> matrix = new Matrix<int>(5, 5);
            matrix.PrintMatrix();



        }
    }
}
