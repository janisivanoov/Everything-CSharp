using System;
using System.Net;
using System.IO;
namespace ClassLibrary1
{
    public class Class_Library
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);
        }
        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
