using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal class Bits : IBitGetable
    {
        public byte Value { get; private set; }

        public Bits(byte value)
        {
            this.Value = value;
        }
        public bool GetBit(byte index)
        {
            return (Value & (1 << index)) != 0 ;
        }

        public void SetBit(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBit(index);
            set => SetBit(index, value);
        }

        public static implicit operator byte(Bits bits) => bits.Value;
        public static explicit operator Bits(byte value) => new (value);

    }
}
