using System;

namespace ShowsTracker
{
    [Serializable]
    public class Show
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public int NextEpisodeNumber { get; set; }

        public Show(string title = "", int nextEpisodeNumber = 1)
        {
            this.ID = Guid.NewGuid();
            this.Title = title;
            this.NextEpisodeNumber = nextEpisodeNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Title, NextEpisodeNumber);
        }
    }
}
