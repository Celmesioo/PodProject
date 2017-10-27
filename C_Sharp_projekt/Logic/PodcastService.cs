using DataAccess;
using System.Collections.Generic;
using System;
using System.Net;
using System.Xml;
using System.Linq;
using System.Xml.Serialization;

namespace Logic
{

    public class PodcastService
    {
        private DataService dataService = new DataService();
        private Validate validator = new Validate();
        private PodcastRepository podcasts = new PodcastRepository();
        private List<string> categories = new List<string>();


        public class PodcastRepository : DataService.XmlRepository<Podcast>
        {
            public PodcastRepository() : base("Podcasts.xml")
            {
 
            }
        }

        public void AddDefaultCategory()
        {
            podcasts.AddCategory("Övrigt");
        }

        public void AddCategory(string input)
        {
            if (validator.Category_does_not_exist(input, categories))
            {
                podcasts.AddCategory(input);
            }
        }
        public List<String> GetCategories()
        {
            return podcasts.GetCategories();
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

        public string[] GetAllPodNames()
        {
            string[] podNames = new string[podcasts.GetListCount()];
            List<Podcast> tempPodList = podcasts.GetAllInList();
            for (int i = 0; i < podNames.Length; i++)
            {
                podNames[i] = tempPodList[i].GetName();
            }

            return podNames;
        }

        public string[] GetPodTitels(string name)
        {
            List<Podcast> tempPodList = podcasts.GetAllInList();
            var podcast = tempPodList.First(n => n.GetName() == name);

            var episodes = podcast.GetAllEpisodes();
            string[] episodesArray = new string[episodes.Count]; 
            for (int i = 0; i < episodes.Count; i++)
            {
                episodesArray[i] = episodes[i].ToString();
            }

            return episodesArray;
        }

        private Podcast CreatePodcast(string url, string name, double interval, string category)
        {
            Podcast newPodcast = new Podcast();
            newPodcast.AddPod(url, name, interval, category);
            return newPodcast;
        }

        public string GetEpisodeLink(string titel, string podname)
        {
            Podcast selectedPod = podcasts.GetByName(podname);
            return selectedPod.GetSpecificEpisodeLink(titel);
        }

        public void DeleteCategory(string toDelete)
        {
            if (validator.If_not_default_category(toDelete))
            {
                podcasts.RemoveCategory(toDelete);
            }
        }

        public bool EpisodeIsDownloaded(string title, string podcastName)
        {
            Podcast selectedPod = podcasts.GetByName(podcastName);
            return selectedPod.IsEpisodeDownloaded(title);
        }

        public void DownloadEpisode(string episodeTitle, string podcastName)
        {
            Podcast selectedPod = podcasts.GetByName(podcastName);
            selectedPod.EpisodeIsDownloaded(episodeTitle);
            podcasts.Download(selectedPod.GetSpecificEpisodeLink(episodeTitle), episodeTitle, podcastName);   
        }

        public string GetPodCategory(string name)
        {
            Podcast p = podcasts.GetByName(name);
            return p._category;
        }

        public string GetPodInterval(string name)
        {
            Podcast p = podcasts.GetByName(name);
            string toReturn = (p.interval / 60000).ToString();
            return toReturn;
        }

        public void PlayEpisode(string title, string podName)
        {
            podcasts.PlayEpisode(title, podName);
        }

        public void SavePodcast(string oldName, string newName, string newCategory, string newInterval)
        {
            Podcast p = podcasts.GetByName(oldName);
            p.Name = newName;
            p._category = newCategory;
            p.interval = double.Parse(newInterval) * 60000;
        }

        public void DeletePodcast(string name)
        {
            podcasts.Remove(podcasts.GetByName(name));
        }
    }
}
