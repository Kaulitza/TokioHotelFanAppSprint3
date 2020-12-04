using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokioHotelFanApp.Models
{
    public class Songs
    {
        string _song_id;
        string _englishName;
        string _germanName;
        string _highestPosition;
        string album_id;
        string _writer_name;
        string _composer_name;

        public Songs(string _song_id, string _germanName, string album_id, string _writer_name, string _composer_name)
        {
            SongId = _song_id;
            GermanName = _germanName;
            Album_id = album_id;
            Writer_name = _writer_name;
            Composer_name = _composer_name;

        }
        public Songs(string _song_id, string _germanName, string _englishName,string album_id, string _writer_name, string _composer_name)
        {
            SongId = _song_id;
            GermanName = _germanName;
            EnglishName = _englishName;
            Album_id = album_id;
            Writer_name = _writer_name;
            Composer_name = _composer_name;

        }

        public string SongId
        {
            get { return _song_id; }
            set { _song_id = value; }
        }

        public string EnglishName
        {
            get { return _englishName; }
            set { _englishName = value; }
        }
        public string GermanName
        {
            get { return _germanName; }
            set { _germanName = value; }
        }
        public string HighestPosition
        {
            get { return _highestPosition; }
            set { _highestPosition = value; }
        }
        public string Album_id
        {
            get { return album_id; }
            set { album_id = value; }
        }
        public string Writer_name
        {
            get { return _writer_name; }
            set { _writer_name = value; }
        }
        public string Composer_name
        {
            get { return _composer_name; }
            set { _composer_name = value; }
        }
    }
}