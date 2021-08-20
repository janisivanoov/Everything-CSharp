using System;
using System.Collections.Generic;
using System.IO;

namespace Work_with_files_and_directories_in_a_.NET_app
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

            foreach (var dir in listOfDirectories)
            {
                Console.WriteLine(dir);
            }
            IEnumerable<string> files = Directory.EnumerateFiles("stores");

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine(file);
            }
        }
    }
}
