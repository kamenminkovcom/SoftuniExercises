using System;

namespace OnlineRadioDatabase
{
    public class SongDuration
    {
        private int minutes;
        private int seconds;

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0 || value > 14)
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                minutes = value;
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                seconds = value;
            }
        }

        public SongDuration(int minutes, int seconds)
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
