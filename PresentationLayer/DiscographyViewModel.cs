using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokioHotelFanApp.BusinessLayer;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.DataLayer.Data;

namespace TokioHotelFanApp.PresentationLayer
{
    public class DiscographyViewModel : ObservableObject
    {
        private ObservableCollection<Albums> _albums;
        private ObservableCollection<Songs> _songs;
        private ObservableCollection<Songs> _searcherSongs;

        private string _criteriaFilter;
        private ComboBoxItem _selectedFilter;
        private Albums _selectedAlbum;
        private Songs _selectedSong;
        public DiscographyView discographyView;




        public ICommand ButtonSearchCommand { get; set; }
        public ICommand RadioCommandSearchCrit { get; set; }
        public ICommand RadioCommandSortSongID { get; set; }
        public ICommand RadioCommandSortSortName { get; set; }
        public ICommand SelectedFilterCommand { get; set; }


        public DiscographyViewModel(ObservableCollection<Albums> albums)
        {
            discographyView =new  DiscographyView();
            Albums = albums;
            this.ButtonSearchCommand = new RelayCommand(this.Search);
            this.RadioCommandSearchCrit = new RelayCommand(this.SetSearchCriteria);
            this.RadioCommandSortSongID = new RelayCommand(new Action<object>(SortID));
            this.RadioCommandSortSortName = new RelayCommand(new Action<object>(SortName));
            this.SelectedFilterCommand = new RelayCommand(this.SetFilter);


        }

        //public ObservableCollection<Songs> SelectedAlbumSongs
        //{
        //    get => this.SelectedAlbum.SongList;
        //    set
        //    {
        //        this.SelectedAlbum.SongList = value;
        //        this.OnPropertyChanged(nameof(this.SelectedAlbumSongs));
        //    }
        //}


        public ObservableCollection<Albums> Albums
        {
            get { return _albums; }
            set
            {
                this._albums = value;
                this.OnPropertyChanged(nameof(Albums));
            }
        }
        public string CriteriaFilter
        {
            get { return _criteriaFilter; }
            set { _criteriaFilter = value; }
        }
        public Albums SelectedAlbum
        {
            get => this._selectedAlbum;
            set
            {
                this._selectedAlbum = value;
                this.OnPropertyChanged(nameof(this.SelectedAlbum));
            }
        }
        public ObservableCollection<Songs> SearchedSongs
        {
            get => this._searcherSongs;
            set
            {
                this._searcherSongs = value;
                this.OnPropertyChanged(nameof(this.SearchedSongs));
            }
        }




        public Songs SelectedSong
        {

            get => this._selectedSong;
            
            set
            {
                this._selectedSong = value;
                this.OnPropertyChanged(nameof(this.SelectedSong));
            }
        }
        
        public ObservableCollection<Songs> Songs
        {
            get { return _songs; }
            set
            {
                this._songs = value;
                this.OnPropertyChanged(nameof(Songs));
            }
        }
        public System.Windows.Controls.ComboBoxItem SelectedFilter
        {
           
            get => this._selectedFilter;
            set
            {
                this._selectedFilter = value;
                this.SetFilter(value);
            }
        }
        public string SearchName { get; set; }

        private void Search(object parameter)
        {

            this.Albums = new ObservableCollection<Albums>(GameSeedData.AlbumObjects());
            this.SearchName = (parameter as TextBox).Text;

            if (!(this.CriteriaFilter is null))
            {
                switch (this.CriteriaFilter.ToUpper())
                {
                    case "ALBUM":
                        SearchedSongs = GameSeedData.AllSongs();

                        for (var i = this.Albums.Count - 1; i >= 0; i--)
                        {
                            var albums = this.Albums[i];

                            if (!string.Equals(albums.AlbumName.Trim().ToUpper(), this.SearchName.Trim().ToUpper(), StringComparison.CurrentCultureIgnoreCase))
                            {
                                this.Albums.RemoveAt(i);
                            }
                        }

                        break;
                    case "SONG":
                        //ListBox listBox = discographyView.SongsListBox;
                        //ObservableCollection<string> nsongs = new ObservableCollection<string>();

                        //foreach (string email in listBox.Items)
                        //{
                        //    nsongs.Add(email);
                        //}
                        SearchedSongs = GameSeedData.AllSongs();
                        for (var i = this.SearchedSongs.Count - 1; i >= 0; i--)
                        {
                            var songs = SearchedSongs[i];

                            if (!string.Equals(songs.GermanName.Trim(), this.SearchName.Trim(), StringComparison.CurrentCultureIgnoreCase))
                            {
                                this.SearchedSongs.RemoveAt(i);
                            }
                        }

                        break;
                }
            }
        }
        private void SetFilter(object parameter)
        {
            switch (this.SelectedFilter.Content)
            {
                case "Song Name":
                    this.SearchedSongs = new ObservableCollection<Songs>(this.SearchedSongs.OrderBy(e => e.SongId));

                    break;
                case "Album Name":
                    this.SearchedSongs = new ObservableCollection<Songs>(this.SearchedSongs.OrderBy(e => e.Album_id));

                    break;
            }
        }

        private void SetSearchCriteria(object parameter)
        {
            this.CriteriaFilter = parameter.ToString();
        }

        private void SortID(object parameter)
        {
             this.SearchedSongs = new ObservableCollection<Songs>(SearchedSongs.OrderBy(x => x.SongId).ToList());
        }

        private void SortName(object parameter)
        {
          this.SearchedSongs = new ObservableCollection<Songs>(SearchedSongs.OrderBy(x => x.GermanName).ToList());
        }

    }
}
