using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class MA_Node
    {
        private string songName;
        private double songPrice;
        private MA_Node prev;
        private MA_Node next;
        public MA_Node(string songName, double songPrice)
        {
            this.songName = songName;
            this.songPrice = songPrice;
            prev = null;
            next = null;
        }

        public string Name
        {
            get
            {
                return songName;
            }
            set
            {
                value = songName;
            }
        }

        public double Price
        {
            get
            {
                return songPrice;
            }
            set
            {
                value = songPrice;
            }
        }

        public MA_Node Next
        {
            get
            {
                return next;
            }
            set
            {
                value = next;
            }
        }

        public MA_Node Previous
        {
            get
            {
                return prev;
            }
            set
            {
                value = prev;
            }
        }


            
            
    }
}
