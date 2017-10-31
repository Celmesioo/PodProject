using DataAccess;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

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
            if (validator.Input_does_not_exist_in_list(input, podcasts.GetCategories()) && validator.Input_not_empty(input))
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

        async public Task AddPodcast(string url, string name, string interval, string category)
        {
            if (validator.Input_not_empty(url, name) && validator.Interval_is_valid(interval) && validator.Input_does_not_exist_in_list(name, podcasts.GetAllPodNames()))
            {
                double intervalAsDouble = double.Parse(interval);
                await Task.Run(() => podcasts.Add(CreatePodcast(url, name, intervalAsDouble, category)));
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

        async public Task DownloadEpisode(string episodeTitle, string podcastName)
        {
            Podcast podcast = GetPodcastByName(podcastName);
            podcast.SetEpisodeIsDownloaded(episodeTitle);
            await  podcasts.Download(podcast.GetSpecificEpisodeLink(episodeTitle), episodeTitle, podcastName);
        }

        public void SavePodcast(string oldName, string newUrl, string newCategory, string newInterval)
        {
            if (validator.Input_not_empty(newUrl))
            {
                Podcast p = GetPodcastByName(oldName);
                p.Category = newCategory;
                p.interval = double.Parse(newInterval) * 60000;
                p.NewUrl(newUrl);
            }
        }

        public void PlayEpisode(string title, string podName)
        {
            Podcast p = GetPodcastByName(podName);
            bool hasListenEarlier = p.EpisodeHasBeenPlayed(title);
            if (!hasListenEarlier)
            {
                p.UserHaveListenToEpisode(title);
            }
            podcasts.PlayEpisode(title, podName, hasListenEarlier); 
        }

        public void AddDefaultCategory() => podcasts.AddCategory("Övrigt");

        public void DeletePodcast(string name) => podcasts.Remove(GetPodcastByName(name));

        public string GetEpisodeLink(string titel, string podcastName) => GetPodcastByName(podcastName).GetSpecificEpisodeLink(titel);

        public string GetPodcastUrl(string name) => GetPodcastByName(name).rss_url;

        public string GetPodCategory(string name) => GetPodcastByName(name).Category;

        public string GetPodInterval(string name) => (GetPodcastByName(name).interval / 60000).ToString();

        public string GetDescription(string podcastName) => GetPodcastByName(podcastName).description;

        public string[] GetAllPodNames() => CreateArrayOfPodNames(podcasts.GetAllInList());

        public string[] FilterByCategory(string category) => CreateArrayOfPodNames(podcasts.GetPodsByCategory(category));

        public bool HasListenTo(string title, string podName) => GetPodcastByName(podName).EpisodeHasBeenPlayed(title);

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

        public void SaveCategory(string newName, string oldName)
        {
            if (validator.If_not_default_category(oldName) && validator.Input_does_not_exist_in_list(newName, podcasts.GetCategories()) && validator.Input_not_empty(newName))
            {
                podcasts.EditCategoryName(newName, oldName);
            }
        }
    }
}
