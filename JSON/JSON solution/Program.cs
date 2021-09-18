using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace JSON_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started program");
            string TextFilePath = @"D:\tokens.json";
            string textt = File.ReadAllText(TextFilePath);
            using (StreamReader r = new StreamReader(TextFilePath))
            {
                string line;
                int num = 1;
                using (WebClient client = new WebClient())
                    while ((line = r.ReadLine()) != null)
                    {
                        client.DownloadFile(line, AppDomain.CurrentDomain.BaseDirectory + $"{num} " + ".jpg");
                        num++;
                    }
            }
            Console.WriteLine("Program done");
            Console.ReadLine();
        }
    }
}