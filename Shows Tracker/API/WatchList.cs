using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;

namespace ShowsTracker
{
    public class WatchList
    {
        public List<Show> Shows { get; set; }
        public Show LatestAddedShow { get; set; }
        public Show LatestEditedShow { get; set; }
        public string FileName { get; set; }

        public WatchList(string fileName = "watchlist.dat")
        {
            this.Shows = new List<Show>();
            this.FileName = fileName;
        }

        public int FindIndex(Guid id)
        {
            return Shows.FindIndex(show => show.ID == id);
        }

        public Show Find(Guid id)
        {
            return Shows.Find(show => show.ID == id);
        }

        public List<Show> Search(string title)
        {
            return Shows.FindAll(show => show.Title.ToLower().Contains(title.ToLower())
                || title.ToLower().Contains(show.Title.ToLower()));
        }

        public Guid[] SearchIDs(string title)
        {
            return Search(title).Select(show => show.ID).ToArray();
        }

        public bool Contains(Guid id)
        {
            return (FindIndex(id) != -1);
        }

        public bool Add(Show show)
        {
            if (FindIndex(show.ID) == -1)
            {
                Shows.Add(show);
                LatestAddedShow = show;
                return true;
            }
            return false;
        }

        public bool Edit(Guid id, Show show)
        {
            int index = FindIndex(id);
            if (index != -1)
            {
                Shows[index].Title = show.Title;
                Shows[index].NextEpisodeNumber = show.NextEpisodeNumber;
                LatestEditedShow = Shows[index];
                return true;
            }
            return false;
        }

        public bool Remove(Guid id)
        {
            int index = FindIndex(id);
            if (index != -1)
            {
                Shows.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool RemoveRange(Guid[] ids)
        {
            foreach (Guid id in ids)
            {
                if (!Remove(id))
                {
                    return false;
                }
            }
            return true;
        }

        public void Save()
        {
            Stream stream = File.OpenWrite(FileName);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, Shows);
            stream.Close();
        }

        public void Load()
        {
            if (File.Exists(FileName))
            {
                Stream stream = File.OpenRead(FileName);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Shows = binaryFormatter.Deserialize(stream) as List<Show>;
                stream.Close();
            }
        }

        public List<string> ToStringList()
        {
            List<string> stringList = new List<string>();
            foreach (Show show in Shows)
            {
                stringList.Add(show.Title);
            }
            return stringList;
        }
    }
}
