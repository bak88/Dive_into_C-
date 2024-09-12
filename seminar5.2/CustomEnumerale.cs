using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar5._2
{
    internal class CustomEnumerale : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator() => new CustomEnumerator();
        

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
