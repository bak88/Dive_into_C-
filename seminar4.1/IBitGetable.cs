using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    //Спроектируйте интерфейс для класса способного устанавливать
    //и получать значения отдельных бит в заданном числе.
    internal interface IBitGetable
    {
        public bool GetBit(byte index);
        public void SetBit(byte index, bool value);
    }
}
