using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal class Collection<T> : IIndexable<T>
    {
        private T[] arr;
        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }

        public Collection(int size)
        {
            arr = new T[size];
        }
    }
}
