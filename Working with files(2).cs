using System;
using System.Net;
using System.Web;
namespace Working_with_files_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(@"https://unic.ac.cy");
            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
