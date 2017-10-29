using DataAccess;
using System.Collections.Generic;
using System;

namespace Logic
{

    public class PodcastService
    {
        private DataService dataService = new DataService();
        private Validate validator = new Validate();
        private PodcastRepository podcasts = new PodcastRepository();


        public class PodcastRepository : Repository.XmlRepository<Podcast>
        {
            public PodcastRepository() : base("Podcasts.xml")
            {
 
            }
        }

        public void AddCategory(string input)
        {
            if (validator.Category_does_not_exist(input, podcasts.GetCategories()))
            {
                podcasts.AddCategory(input);
            }
        }

        public void LoadPodcasts()
        {
            foreach (Podcast pod in podcasts.GetAllInList())
            {
                pod.ActivateUpdateInterval();
            }
        }

        public void AddPodcast(string url, string name, string interval, string category)
        {
            if (validator.Input_not_empty(url, name) && validator.Interval_is_valid(interval))
            {
                double intervalAsDouble = double.Parse(interval);
                podcasts.Add(CreatePodcast(url, name, intervalAsDouble, category));
            }
            
        }

        public string[] GetPodTitels(string name)
        {
            var episodes = GetPodcastByName(name).GetAllEpisodes;

            string[] episodesArray = new string[episodes.Count]; 
            for (int i = 0; i < episodes.Count; i++)
            {
                episodesArray[i] = episodes[i].ToString();
            }

            return episodesArray;
        }

        public void DeleteCategory(string toDelete)
        {
            if (validator.If_not_default_category(toDelete))
            {
                podcasts.RemoveCategory(toDelete);
            }
        }

        public bool EpisodeIsDownloaded(string title, string podcastName) => GetPodcastByName(podcastName).IsEpisodeDownloaded(title);

        public void DownloadEpisode(string episodeTitle, string podcastName)
        {
            Podcast podcast = GetPodcastByName(podcastName);
            podcast.SetEpisodeIsDownloaded(episodeTitle);
            podcasts.Download(podcast.GetSpecificEpisodeLink(episodeTitle), episodeTitle, podcastName);   
        }

        public void SavePodcast(string oldName, string newUrl, string newCategory, string newInterval)
        {
            Podcast p = GetPodcastByName(oldName);
            p.Category = newCategory;
            p.interval = double.Parse(newInterval) * 60000;
            p.NewUrl(newUrl);
        }

        public void AddDefaultCategory() => podcasts.AddCategory("Övrigt");

        public void DeletePodcast(string name) => podcasts.Remove(GetPodcastByName(name));

        public void PlayEpisode(string title, string podName) => podcasts.PlayEpisode(title, podName);

        public string GetEpisodeLink(string titel, string podcastName) => GetPodcastByName(podcastName).GetSpecificEpisodeLink(titel);

        public string GetPodcastUrl(string name) => GetPodcastByName(name).rss_url;

        public string GetPodCategory(string name) => GetPodcastByName(name).Category;

        public string GetPodInterval(string name) => (GetPodcastByName(name).interval / 60000).ToString();

        public string GetDescription(string podcastName) => GetPodcastByName(podcastName).description;

        public string[] GetAllPodNames() => CreateArrayOfPodNames(podcasts.GetAllInList());

        public string[] FilterByCategory(string category) => CreateArrayOfPodNames(podcasts.GetPodsByCategory(category));

        public List<String> GetCategories() => podcasts.GetCategories();


        private Podcast CreatePodcast(string url, string name, double interval, string category)
        {
            Podcast newPodcast = new Podcast(url, name, interval, category);
            return newPodcast;
        }

        private String[] CreateArrayOfPodNames(List<Podcast> podList)
        {
            string[] podNames = new string[podList.Count];
            for (int i = 0; i < podNames.Length; i++)
            {
                podNames[i] = podList[i].Name;
            }

            return podNames;
        }

        private Podcast GetPodcastByName(string name) => podcasts.GetByName(name);
    }
}
