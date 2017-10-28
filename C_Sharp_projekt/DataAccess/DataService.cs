using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace DataAccess
{
    public class DataService
    {
        const string path = @"c:\XML\";

        public interface IPod
        {
            string Name { get; set; }
            string Category { get; set; }
        }

        public abstract class XmlRepository<T> where T : IPod
        {
            private string _XmlPath;
            private List<T> _items = new List<T>();
            private List<String> _categories = new List<string>();

            public XmlRepository(string pathToXml)
            {
                _XmlPath = pathToXml;

                if (File.Exists(path + _XmlPath))
                {
                    _items = LoadItems();
                }
                if (File.Exists(path + "Categories.xml"))
                {
                    _categories = LoadCategories();
                }
            }

            private List<T> LoadItems()
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var stream = new StreamReader(path + _XmlPath))
                {
                    var podcasts = (List<T>)serializer.Deserialize(stream);
                    return podcasts;
                }
            }

            private void SaveItems()
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                var stringwriter = new StringWriter();
                serializer.Serialize(stringwriter, _items);
                SaveXml(stringwriter.ToString(), "Podcasts");
            }

            private List<string> LoadCategories()
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                using (var stream = new StreamReader(path + "Categories.xml"))
                {
                    var categories = (List<string>)serializer.Deserialize(stream);
                    return categories;
                }
            }
            private void SaveCategories()
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

                var stringwriter = new StringWriter();
                serializer.Serialize(stringwriter, _categories);
                SaveXml(stringwriter.ToString(), "Categories");
            }

            

            private static void SaveXml(string xml, string name)
            {
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }

                using (var stream = new FileStream(
                    $@"c:\XML\{name}.xml",
                    FileMode.Create,
                    FileAccess.ReadWrite))
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.Write(xml);
                    }
                }
            }

            public void AddCategory(String c)
            {
                _categories.Add(c);
                SaveCategories();
            }

            public List<string> GetCategories()
            {
                return _categories;
            }

            public List<T> GetPodsByCategory(string category)
            {
                var podList = from item in _items
                              where item.Category.Equals(category)
                              select item;

                List<T> p = new List<T>();
                foreach (var item in podList)
                {
                    p.Add(item);
                }
                return p;
            }

            public void Add(T item)
            {
                _items.Add(item);
                CreateFolder(item.Name);
                SaveItems();
            }

            public void Remove(T item)
            {
                _items.Remove(item);
                SaveItems();
            }

            public int GetListCount()
            {
                return _items.Count;
            }

            public List<T> GetAllInList()
            {
                return _items;
            }

            public T GetByName(string name)
            {
                foreach (var item in _items)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
                return default(T);
            }

            public void RemoveCategory(string toDelete)
            {
                ChangeToDefaultCategory(toDelete);
                _categories.Remove(toDelete);
                SaveItems();
                SaveCategories();
            }

            private void ChangeToDefaultCategory(string toDelete)
            {
                List<T> t = GetPodsByCategory(toDelete);
                foreach (var item in t)
                {
                    item.Category = "Övrigt";
                }
            }

            private void CreateFolder(string folderName)
            {
                Directory.CreateDirectory(path + folderName + @"\");
            }

            public void Download(string url, string title, string podName)
            {

                using (WebClient wc = new WebClient())
                {
                    Uri mp3Uri = new Uri(url);
                    title = RemoveInvalidCharacters(title);
                    string fileName = path + podName + @"\" + title + ".mp3";
                    wc.DownloadFileAsync(mp3Uri, fileName);
                }
                SaveItems();
            }

            public void PlayEpisode(string title, object podName)
            {
                title = RemoveInvalidCharacters(title);
                string fileName = path + podName + @"\" + title + ".mp3";
                Process.Start(fileName);
            }
        }

        public static string GetDescription(string url)
        {
            var xml = String.Empty;
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            var dom = new XmlDocument();
            dom.LoadXml(xml);
            var baseNode = dom.DocumentElement.SelectSingleNode("channel");
            string description = baseNode.SelectSingleNode("description").InnerText;

            return description;
        }

        public static Dictionary<string, string> Get_episode_title_n_link(String url)
        {
            var xml = String.Empty;
            Dictionary<string, string> episodes = new Dictionary<string, string>();

            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            var dom = new XmlDocument();
            dom.LoadXml(xml);
            
            foreach (XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                String title = item.SelectSingleNode("title").InnerText;
                String link = item.SelectSingleNode("link").InnerText;
                episodes.Add(title, link);
            }
            return episodes;
        }

        

        internal static string RemoveInvalidCharacters(string title)
        {
            title = title.Replace("%", string.Empty);
            title = title.Replace("!", string.Empty);
            title = title.Replace("#", string.Empty);
            title = title.Replace("&", string.Empty);
            title = title.Replace(":", string.Empty);
            title = title.Replace("+", string.Empty);
            title = title.Replace(" ", "-");
            title = title.Replace(".", string.Empty);
            title = title.Replace("?", string.Empty);

            return title;
        }
    }
}
