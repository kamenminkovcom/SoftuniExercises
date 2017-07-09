using System;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artistName;
        private string songName;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongDuration = new SongDuration(minutes, seconds);
        }

        public string ArtistName
        {
            get => artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                artistName = value;
            }
        }

        public string SongName
        {
            get => songName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                    throw new ArgumentException("Song name should be between 3 and 20 symbols.");
                songName = value;
            }
        }

        public SongDuration SongDuration { get; set; }
    }
}
