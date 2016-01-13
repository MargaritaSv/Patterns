using System;
using System.Collections.Generic;
using System.Linq;

namespace Facada
{
    public class PLay : IPlayer
    {
        private readonly ICollection<MediaEntity> playList;

        private int currIndex;

        public PLay()
        {
            this.playList = new List<MediaEntity>();
        }

        public void Play()
        {
            if (!this.playList.Any())
            {
                Console.WriteLine("There is no song in playlist.Please add some.");
                return;
            }

            var currentPlaylistItem = this.playList.ElementAtOrDefault(this.currIndex);

            if (currentPlaylistItem == null)
            {
                Console.WriteLine("The item is not found.");
                return;
            }

            Console.WriteLine($"Started playing {currentPlaylistItem.Title} . {currentPlaylistItem.FileExtention}");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!");
            this.currIndex = 0;
        }

        public void Next()
        {
            this.currIndex++;
            if (this.currIndex >= this.playList.Count)
            {
                this.currIndex++;
            }

            Console.WriteLine("Swith to the next song...");
        }

        public void Previous()
        {
            this.currIndex--;
            if (this.currIndex < 0)
            {
                this.currIndex = this.playList.Count - 1;
            }

            Console.WriteLine("Swith to the previous song...");
        }

        public void Load(MediaEntity media)
        {
            this.playList.Add(media);
            Console.WriteLine($"Loaded {media.Title} . {media.FileExtention}");
        }
    }
}
