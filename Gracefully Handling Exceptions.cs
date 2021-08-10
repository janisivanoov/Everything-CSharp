using System;
using System.IO;

namespace Gracefully_Handling_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = FileStyleUriParser.ReadAllText(@"C:\File.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There is a problem with file name");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There is a problem with directory of file");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is a problem" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing application");
            }
            Console.ReadLine();
        }
    }
}
