using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class ServiceSongs
    {
        public String songName;
        public Double songPrice;

        public ServiceSongs(String songName, Double songPrice)
        {
            this.songName = songName;
            this.songPrice = songPrice;

        }

        public String SongName
        {
            set
            {
                songName = value;
            }
            get
            {
                return songName;
            }
        }

        public Double SongPrice
        {
            set
            {
                songPrice = value;
            }
            get
            {
                return songPrice;
            }
        }
    }
}

