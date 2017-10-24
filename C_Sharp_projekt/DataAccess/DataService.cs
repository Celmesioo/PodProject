using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DataAccess
{
    public class DataService
    {
        const string path = @"c:\XML\";

        public interface IPod
        {
            string Name { get; set; }
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

            public void Add(T item)
            {
                _items.Add(item);
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
    }

    
}
