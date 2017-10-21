using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Podcast : DataService.IPod
    {
        public string _rss_url;
        public string _category;
        public List<Episode> podEpisodes= new List<Episode>();
        public string Name { get; set; }

        public Podcast()
        {

        }

        public void AddPod(string url, string name, string category = "övrigt")
        {
            _rss_url = url;
            Name = name;
            _category = category;
            AddEpisodes();
        }

        public string GetName()
        {
            return Name;
        }
        public string GetUrl()
        {
            return _rss_url;
        }

        public List<Episode> GetAllEpisodes()
        {
            return podEpisodes;
        }

        public void AddEpisodes()
        {
            var episodesAsDictionary = DataService.Get_episode_title_n_link(_rss_url);
            foreach (KeyValuePair<string,string> item in episodesAsDictionary)
            {
                podEpisodes.Add(new Episode(item.Key, item.Value));
            }
        }

        public class Episode
        {
            public string title;
            public string link;
            private bool _hasListenTo = false;

            public Episode()
            {

            }
            public Episode(string title, string link)
            {
                this.title = title;
                this.link = link;
            }

            public override string ToString()
            {

                return $"Episod: {title}";
            }
        }
    }


   
}
