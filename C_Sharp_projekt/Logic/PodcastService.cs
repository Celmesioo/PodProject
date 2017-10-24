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
            categories.Add("Övrigt");
        }

        public void AddCategory(string input)
        {
            if (validator.Category_does_not_exist(input, categories))
            {
                categories.Add(input);
            }
        }
        public List<String> GetCategories()
        {
            return categories;
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
    }
}
