using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    internal class BabySitter : IBabySitter
    {
        public void TakeCare()
        {
            Console.WriteLine("Смотрит детей пока родителей нет дома");
        }
    }
}
