using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokioHotelFanApp.Models
{
    public class Top5
    {
        int _top5_id;
        int _user_id;
        int _first_song_id;
        int _second_song_id;
        int _third_song_id;
        int _forth_song_id;
        int _fifth_song_id;

        public int Top5Id
        {
            get { return _top5_id; }
            set { _top5_id = value; }
        }

        public int UserID
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public int First_song_id
        {
            get { return _first_song_id; }
            set { _first_song_id = value; }
        }
        public int Second_song_id
        {
            get { return _second_song_id; }
            set { _second_song_id = value; }
        }
        public int Third_song_id
        {
            get { return _third_song_id; }
            set { _third_song_id = value; }
        }
        public int Forth_song_id
        {
            get { return _forth_song_id; }
            set { _forth_song_id = value; }
        }
        public int Fifth_song_id
        {
            get { return _fifth_song_id; }
            set { _fifth_song_id = value; }
        }

    }
}
