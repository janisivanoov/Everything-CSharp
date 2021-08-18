using System;
using System.IO;

namespace Interface__virtual_void__class__void
{
    public class y
    {
        public void x()
        {
            var path = @"D:\Folder";
            using (var file = File.Open(path, FileMode.Open))
            {

            }
        }
    }
    class Program
    {
        private string name;

        public string Name { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            try
            {
                Process();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            finally
            {
                Console.WriteLine("No exceptions");
            }


        }
        public override void set__name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value");
            }
            if(value == this.name)
            {
                throw new ArgumentException("value is duplicate");
            }
            if(value.Length > 10)
            {
                throw new ArgumentException("value is too long");
            }
            this.Name = value;
        }
        public void Process()
        {
            Console.WriteLine("Hello");
        }
    }
    interface IDisposable {
        void Dispose();
    }
    public class Demo : IDisposable
    {
        public void Dispose()
        {

        }
    }
    public class AdvancedDemo : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }
        ~AdvancedDemo()
        {
            Dispose(false);
        }
    }
}
