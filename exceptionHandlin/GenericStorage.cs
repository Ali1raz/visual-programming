using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlin
{
    internal class GenericStorage<T>
    {
        private T[] items = new T[10];

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= items.Length) throw new ArgumentOutOfRangeException("index outof range");
                return items[index];
            }

            set
            {
                if (index < 0 || index >= items.Length) throw new ArgumentOutOfRangeException("index outof range");
                items[index] = value;
            }
        }
    }
}
