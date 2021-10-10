using System;
using System.IO;
namespace Test_TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*For void WriteToFile*/
            log(@"D:\Folder", "TestFile", "Here suppose to be a message");


            /*Reading*/
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"D:\Folder\TestFile.txt");
                line = sr.ReadLine(); /*reading first line*/
                while (line != null) /*read till line didnt end*/
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine(); /*reading next line*/
                }
                sr.Close(); /*closing*/
                Console.ReadLine();
            }
            /*catching exceptions*/
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();
        }
        static void log(string directory, string name, string message)
        {
            string filename = String.Format("{0:YYYYMMDDhhmmssfff}__{1}", DateTime.Now, name);
            string path = Path.Combine(directory, filename);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("This is just a test");
            }
        }
    }
}
