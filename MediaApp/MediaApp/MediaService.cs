using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    class MediaService : IMedia
    {
        private int size;
        private double balance; 
        public ServiceSongs[] songs;

        public MediaService()
        {
            this.size = 10;
            songs = new ServiceSongs[size];
            balance = 0;
        }

        public void addSongs()
        {
            songs[0] = new ServiceSongs("Vossi Bop, Stormzy", 3.49);
            songs[1] = new ServiceSongs("Old Town Road, Lil Nas X", 2.49);
            songs[2] = new ServiceSongs("Someone You Loved, Lewis Capaldi", 3.49);
            songs[3] = new ServiceSongs("Hold Me While You Wait, Lewis Capaldi", 2.49);
            songs[4] = new ServiceSongs("bad guy, Billie Eilish", 3.49);
            songs[5] = new ServiceSongs("Piece Of Your Heart (feat. Goodboys), Meduza", 2.49);
            songs[6] = new ServiceSongs("ME! (feat. Brendon Urie), Taylor Swift", 3.49);
            songs[7] = new ServiceSongs("SOS (feat. Aloe Bacc), Avicii", 2.49);
            songs[8] = new ServiceSongs("If I Can't Have You, Shawn Mendes", 3.49);
            songs[9] = new ServiceSongs("Just You and I, Tom Walker", 2.49);
        }
        public object ListSongs(ListBox lstSongs)
        {
            for (int x = 0; x < songs.Length; x++)
            {
                lstSongs.Items.Add(songs[x].SongName + "       £ " + songs[x].SongPrice);
            }
            return lstSongs;
        }

        public void deposit(double money)
        {
            balance = balance + money;
        }

        public bool withdraw(double money)
        {
            throw new NotImplementedException();
            //Not needed
        }

        public virtual string displayStatement()
        {
            return balance.ToString();
        }

        public void purchase(double amount)
        {
            balance = balance - amount;
        }
    }
}
