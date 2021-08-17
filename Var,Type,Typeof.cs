using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Var__Type__typeof
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "Hello There!";
            var value = source.Substring(4, 5);
            value = string.Concat(value, "There");
            value = value.Replace("Hello", "There!");
            value = value.ToUpper();
            var array = "Hello".ToArray();
            var bytes = Encoding.ASCII.GetBytes("Hello");

            var split = source.Split(' ');
            var valuee = split[1];
            var pattern = @"\b\w+\b";
            var matches = Regex.Matches(source, pattern);
            value = matches[1].Value;
            pattern = "(Hello )(.+)(ere)";
            var groups = Regex.Match(source, pattern).Groups;

            var dog = new Dog { NumberOfLegs = "4" };
            Type t1 = typeof(Dog);
            Type t2 = dog.GetType();
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Assembly);
            var newDog = (Dog)Activator.CreateInstance(typeof(Dog));
            var genericDog = Activator.CreateInstance<Dog>();
            var dogConstructor = typeof(Dog).GetConstructors()[0];
            var advancedDog = (Dog)dogConstructor.Invoke(null);

            void Property()
            {
                var horse = new Animal() { Name = "Ed" };
                var type = horse.GetType();
                var property = type.GetProperty("Name");
                var value = property.GetValue(horse, null);
            }
            void Method()
            {
                var horse = new Animal();
                var type = horse.GetType();
                var method = type.GetMethod("Speak");
                var value = (string)method.Invoke(horse, null);
            }
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public string Speak() { return "Hello"; }
    }
    public class Dog
    {
        public string NumberOfLegs { get; set; }
    }
}
