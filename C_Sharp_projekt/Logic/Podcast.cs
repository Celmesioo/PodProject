using DataAccess;
using System;
using System.Collections.Generic;
using System.Timers;

namespace Logic
{
    public class Podcast : Repository.IPod
    {
        public string rss_url;
        public double interval;
        public string description;
        public List<Episode> podEpisodes = new List<Episode>();
        public string Name { get; set; }
        public string Category { get; set; }

        private Timer timer = new Timer();

        public Podcast()
        {

        }

        public Podcast(string url, string name, double interval, string category)
        {
            rss_url = url;
            this.interval = interval*60000;
            Name = name;
            Category = category;
            AddDescription();
            AddEpisodes();
            ActivateUpdateInterval();
        }

        public List<Episode> GetAllEpisodes => podEpisodes;

        internal void ActivateUpdateInterval()
        {
            timer.Interval = interval;
            timer.Elapsed += LookForNewEpisodes;
            timer.Enabled = true;
            timer.AutoReset = true; 
        }

        internal void NewUrl(string newUrl)
        {
            if (rss_url != newUrl)
            {
                rss_url = newUrl;
                podEpisodes.Clear();
                AddEpisodes();
            }
        }

        internal string GetSpecificEpisodeLink(string title) => GetEpisodeByTitle(title).link;

        internal void SetEpisodeIsDownloaded(string title) => GetEpisodeByTitle(title).isDownloaded = true;

        internal bool IsEpisodeDownloaded(string title) => GetEpisodeByTitle(title).isDownloaded;

        internal bool EpisodeHasBeenPlayed(string title) => GetEpisodeByTitle(title).hasListenTo;

        private void LookForNewEpisodes(object sender, ElapsedEventArgs e)
        {
            var episodes = FindEpisodes;
            if (episodes.Count > podEpisodes.Count)
            {
                int NumberOfNewEpisodes = episodes.Count - podEpisodes.Count;
                AddNewEpisode(episodes, NumberOfNewEpisodes);
            }
        }

        private void AddEpisodes()
        {
            var episodes = FindEpisodes;
            foreach (KeyValuePair<string, string> item in episodes)
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

        internal void UserHaveListenToEpisode(string title)
        {
            GetEpisodeByTitle(title).hasListenTo = true;
        }

        private void AddDescription() => description = DataService.GetDescription(rss_url);

        private Dictionary<string, string> FindEpisodes => DataService.Get_episode_title_n_link(rss_url);

        

        public class Episode
        {
            public string title;
            public string link;
            public bool isDownloaded;
            public bool hasListenTo;

            public Episode()
            {

            }
            public Episode(string title, string link)
            {
                this.title = title;
                this.link = link;
                isDownloaded = false;
                hasListenTo  = false;
            }

            public override string ToString()
            {
                return $"Episod: {title}";
            }
        }

        
    }
}
