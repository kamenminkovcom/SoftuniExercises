using System;

namespace OnlineRadioDatabase
{
    class StartUp
    {
        private static Playlist playlist = new Playlist();

        static void Main()
        {
            int songs = int.Parse(Console.ReadLine());

            for (int i = 0; i < songs; i++)
            {
                string[] songInfo = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(playlist.AddSong(songInfo));
            }

            Console.WriteLine(playlist.ToString());
        }
    }
}
