using System.Collections.Generic;

namespace Facada
{
    public class Database
    {
        private readonly ICollection<MediaEntity> availableMedia;

        public Database()
        {
            this.availableMedia = new List<MediaEntity>();
        }

        public IEnumerable<MediaEntity> GetAvailableMedia()
        {
            return this.availableMedia;
        }

        public void Add(MediaEntity media)
        {
            this.availableMedia.Add(media);
        }
    }
}
