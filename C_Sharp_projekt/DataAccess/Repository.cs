using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Serialization;

namespace DataAccess
{
    public class Repository
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

            public void AddCategory(String c)
            {
                _categories.Add(c);
                SaveCategories();
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
                CreateFolder(RemoveInvalidCharacters(item.Name));
                SaveItems();
            }

            public void Remove(T item)
            {
                _items.Remove(item);
                DeleteFolder(RemoveInvalidCharacters(item.Name));
                SaveItems();
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

            public int GetListCount() => _items.Count;

            public List<T> GetAllInList() => _items;

            public List<string> GetCategories() => _categories;

            private void ChangeToDefaultCategory(string toDelete)
            {
                List<T> t = GetPodsByCategory(toDelete);
                foreach (var item in t)
                {
                    item.Category = "Övrigt";
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

            private void DeleteFolder(string folderName)
            {
                Directory.Delete(path + folderName, true);
            }

            private void CreateFolder(string folderName) => Directory.CreateDirectory(path + folderName + @"\");

            private static string RemoveInvalidCharacters(string title)
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
}
