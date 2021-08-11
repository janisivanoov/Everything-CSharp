using System;
using System.IO;

namespace ReaderOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FileStream fstream = File.OpenRead(@"D:\text.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Text from file" + textFromFile);
            }
            Console.ReadLine();
        }
    }
}
