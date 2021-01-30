using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DAO;
using MusicApp.DTO;

namespace MusicApp.static_class
{
    public class passSongToPlayBarEventArgs : EventArgs
    {
        
        public passSongToPlayBarEventArgs(song passSong, bool addPlaylist = false, bool addalbum=false)
        {
            checkAlbum = addalbum;
            checkAdd = addPlaylist;
            slectedSong = passSong;
        }

        public song slectedSong { get; set; }
        public bool checkAdd { get; set; }
        public bool checkAlbum { get; set; }

    }
}
