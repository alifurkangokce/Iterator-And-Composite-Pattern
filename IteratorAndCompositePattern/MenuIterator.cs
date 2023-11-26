using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
   public class MenuIterator<T> : IIterator<T>
    {
        private List<T> items;
        private int position = 0;

        public MenuIterator(List<T> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public T Next()
        {
            T item = items[position];
            position++;
            return item;
        }
    }
}
