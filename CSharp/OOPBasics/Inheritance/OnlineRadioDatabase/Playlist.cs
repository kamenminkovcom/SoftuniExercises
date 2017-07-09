using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Playlist
    {
        public Playlist()
        {
            this.Songs = new List<Song>();
        }

        public List<Song> Songs { get; }

        public string AddSong(string[] songInfo)
        {
            Song song;
            try
            {
                string artistName = songInfo[0];
                string songName = songInfo[1];
                string[] durationInfo = songInfo[2].Split(new[] {":"}, StringSplitOptions.RemoveEmptyEntries);
                int minutes = int.Parse(durationInfo[0]);
                int seconds = int.Parse(durationInfo[1]);
                song = new Song(artistName, songName, minutes, seconds);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            Songs.Add(song);
            return "Song added.";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Songs added: {Songs.Count}")
                  .Append($"Playlist length: {PlaylistLength()}");

            return result.ToString();
        }

        private string PlaylistLength()
        {
            int seconds = Songs.Select(x => x.SongDuration.Minutes * 60 + x.SongDuration.Seconds).Sum();
            int hours = seconds / 3600;
            seconds = seconds % 3600;
            int minutes = seconds / 60;
            seconds = seconds % 60;
            return $"{hours}h {minutes}m {seconds}s";
        }
    }
}
