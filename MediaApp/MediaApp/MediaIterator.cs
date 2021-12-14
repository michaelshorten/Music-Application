using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class MediaIterator : Iterator
    {
        private MediaAccount collection;
        private int size;
        private MA_Node current;

        public MediaIterator(MediaAccount collection)
        {
            this.collection = collection;
            size = collection.getSize;
            current = collection.Head;
        }
        public string getNext()
        {
            MA_Node oldCurrent = current;
            current = current.Previous;
            return oldCurrent.Name + oldCurrent.Price;
            //return size.ToString();
        }

        public bool hasMore()
        {
            return current != null;
        }
    }
}
