﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace DataAccess
{
    public class DataService
    {
        
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
            try
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
            catch (WebException)
            {
                string s = "Kunde inte hitta URL, kontrollera och försök igen.";
                throw new WebException(s);
            }
           
        }
    }
}
