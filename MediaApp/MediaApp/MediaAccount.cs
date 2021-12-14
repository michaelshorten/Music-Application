using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class MediaAccount: IterableCollection
    {
        private MA_Node head;
        private int size;

        public MediaAccount()
        {
            head = null;
            size = 0;

        }
        public Iterator createIterator()
        {
            return new MediaIterator(this);
        }

        public void InsertFront(MA_Node newdata)
        {
            MA_Node data = new MA_Node(newdata.Name, newdata.Price);

           
                if(head != null)
                {
                    head.Previous = data;
                }
                
                data.Next = head;
                
                head = data;
                size++;
  
        }

        public int getSize
        {
            get
            {
                return size;
            }
        }

        public MA_Node Head
        {
            get
            {
                return head;
            }

        }

    }
}
