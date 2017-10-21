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


        public class PodcastRepository : DataService.XmlRepository<Podcast>
        {

            public PodcastRepository() : base("Podcasts.xml")
            {
            }
        }

        public void LoadPodcasts()
        {
            
        }

        public void AddPodcast(string url, string name)
        {
            if (validator.Input_not_empty(url, name))
            {
                
                podcasts.Add(CreatePodcast(url, name));
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

        private Podcast CreatePodcast(string url, string name)
        {
            Podcast newPodcast = new Podcast();
            newPodcast.AddPod(url, name);
            return newPodcast;
        }
    }
}
