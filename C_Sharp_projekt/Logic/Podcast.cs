using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Logic
{
    public class Podcast : DataService.IPod
    {
        Timer timer = new Timer();
        public string _rss_url;
        public string _category;
        public double interval;
        public List<Episode> podEpisodes = new List<Episode>();
        public string Name { get; set; }

        public Podcast()
        {

        }

        public void AddPod(string url, string name, double interval, string category)
        {
            _rss_url = url;
            this.interval = interval*60000;
            Name = name;
            _category = category;
            AddEpisodes();
        }

        public void ActivateUpdateInterval()
        {
            timer.Interval = interval;
            timer.Elapsed += LookForNewEpisodes;
            timer.Enabled = true;
            timer.AutoReset = true;
            
        }

        public string GetSpecificEpisodeLink(string title)
        {
            return GetEpisodeByTitle(title).link;
        }

        public void EpisodeIsDownloaded(string title)
        {
            GetEpisodeByTitle(title).isDownloaded = true;
        }

        public bool IsEpisodeDownloaded(string title)
        {
            return GetEpisodeByTitle(title).isDownloaded;
        }

        private void LookForNewEpisodes(object sender, ElapsedEventArgs e)
        {
            var episodes = FindEpisodes;
            if (episodes.Count > podEpisodes.Count)
            {
                int NumberOfNewEpisodes = FindEpisodes.Count - podEpisodes.Count;
                AddNewEpisode(episodes, NumberOfNewEpisodes);
            }
        }

        public string GetName()
        {
            return Name;
        }
        public string GetUrl()
        {
            return _rss_url;
        }

        private Episode GetEpisodeByTitle(string title)
        {
            foreach (var episode in podEpisodes)
            {
                if (episode.ToString().Equals(title))
                {
                    return episode;
                }
            }
            throw new ApplicationException("Kunde inte hitta episoden");
        }

        public List<Episode> GetAllEpisodes()
        {
            return podEpisodes;
        }

        public void AddEpisodes()
        {
            var episodes = FindEpisodes;
            foreach (KeyValuePair<string,string> item in episodes)
            {
                podEpisodes.Add(new Episode(item.Key, item.Value));
            }
        }

        private void AddNewEpisode(Dictionary<string, string> newEpisodes, int nr_of_episodes)
        {
            int count = 0;
            foreach (KeyValuePair<string, string> item in newEpisodes)
            {
                podEpisodes.Insert(0, new Episode(item.Key, item.Value));
                count++;
                if (count >= nr_of_episodes)
                {
                    break;
                }
            }
        }



        private Dictionary<string, string> FindEpisodes => DataService.Get_episode_title_n_link(_rss_url);

        

        public class Episode
        {
            public string title;
            public string link;
            public bool isDownloaded;
            private bool _hasListenTo = false;

            public Episode()
            {

            }
            public Episode(string title, string link)
            {
                this.title = title;
                this.link = link;
                isDownloaded = false;
            }

            public override string ToString()
            {

                return $"Episod: {title}";
            }
        }
    }


   
}
