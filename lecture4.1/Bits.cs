using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    internal class Bits
    {
        public byte Value { get; private set; } = 0;

        public Bits(byte b) { this.Value = b; }
        public static implicit operator byte(Bits bits) { return bits.Value; }
        public static explicit operator Bits(byte b) { return new Bits(b); }
    }
}
