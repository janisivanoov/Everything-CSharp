using System;
using System.Diagnostics;
using System.IO.IsolatedStorage;

namespace var_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = System.IO.Directory.GetCurrentDirectory();
            var file = System.IO.Path.Combine(dir, "File.txt");
            var content = "Hello there";
            System.IO.File.WriteAllText(file , content);
            var read = System.IO.File.ReadAllText(file);
            Trace.Assert(read.Equals(content));
            var docs = Environment.SpecialFolder.MyDocuments;
            var app = Environment.SpecialFolder.CommonApplicationData;
            var prog = Environment.SpecialFolder.ProgramFiles;
            var desk = Environment.SpecialFolder.Desktop;
            var iso = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly, "Demo").GetDirectoryNames("*");
            foreach(var item in System.IO.Directory.GetFiles(dir))
            {
                Console.WriteLine(System.IO.Path.GetFileName(item));
            }
            var path1 = @"D:\Folder\file1.txt";
            var path2 = @"D:\Folder\file2.txt";
            System.IO.File.Move(path1, path2);
            var info = new System.IO.FileInfo(path1);
            Console.WriteLine("{0}kb", info.Length / 1000);
        }
    }
}
