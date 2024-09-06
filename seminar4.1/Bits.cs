using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal class Bits : IBitGetable
    {
        public long ValueLong { get; private set; }
        public int ValueInt { get; private set; }

        public int Size { get; private set; }

        public Bits(byte value)
        {
            this.ValueLong = value;
            this.Size = sizeof(byte);
        }

        public Bits(int value)
        {
            this.ValueLong = value;
            this.Size = sizeof(int);
        }

        public Bits(long value)
        {
            this.ValueLong = value;
            this.Size = sizeof(long);
        }
        public bool GetBit(byte index)
        {
            return (ValueLong & (1 << index)) != 0 ;
        }

        public void SetBit(byte index, bool value)
        {
            if (value)
            {
                ValueLong |= (byte)(1 << index);
            }
            else
            {
                ValueLong &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBit(index);
            set => SetBit(index, value);
        }

        public static implicit operator long(Bits bits) => bits.ValueLong;
        public static explicit operator Bits(long value) => new (value);

        public static implicit operator int(Bits bits)
        {
            return bits.ValueLong;
        }

    }
}
