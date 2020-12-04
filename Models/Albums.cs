using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TokioHotelFanApp.Models
{
    public class Albums
    {
        string _album_id;
         string _albumName;
        string _releaseDate;
        string _numberofSongs;
        private ObservableCollection<Songs>  _songList;
        string _numberofHits;
        string _amountSold;
        string _recordCompany;
        public Albums()
        {

        }
        public Albums(string _album_id, string _albumName, string _releaseDate, string _numberofSongs, string _numberofHits, string _amountSold, string _recordCompany, ObservableCollection<Songs> songs)
        {
            AlbumId = _album_id;
            AlbumName = _albumName;
            ReleaseDate = _releaseDate;
            NumberofSongs = _numberofSongs;
            NumberofHits = _numberofHits;
            AmountSold = _amountSold;
            RecordCompany = _recordCompany;
            SongList = songs;
        }


        public Albums(string _album_id, string _albumName, string _releaseDate, string _numberofSongs, string _numberofHits, string _amountSold, string _recordCompany)
        {
            AlbumId = _album_id;
            AlbumName = _albumName;
            ReleaseDate = _releaseDate;
            NumberofSongs = _numberofSongs;
            NumberofHits = _numberofHits;
            AmountSold = _amountSold;
            RecordCompany = _recordCompany;
        }
        public string AlbumId
        {
            get { return _album_id; }
            set { _album_id = value; }
        }
        public ObservableCollection<Songs> SongList
        {
            get;
            set;
        }
        public string AlbumName
        {
            get { return _albumName; }
            set { _albumName = value; }
        }
        public string ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }
        public string NumberofSongs
        {
            get { return _numberofSongs; }
            set { _numberofSongs = value; }
        }
        public string NumberofHits
        {
            get { return _numberofHits; }
            set { _numberofHits = value; }
        }
        public string AmountSold
        {
            get { return _amountSold; }
            set { _amountSold = value; }
        }
        public string RecordCompany
        {
            get { return _recordCompany; }
            set { _recordCompany = value; }
        }

    }
}
