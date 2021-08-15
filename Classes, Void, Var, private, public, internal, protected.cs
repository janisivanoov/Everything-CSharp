using System;
using System.Collections;

namespace Private_Public_Protected_Internal_Staff
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();
            var derivedOverride = new DerivedOverride();
            var derivedNew = new DerivedNew();

            baseClass.Name();
            derivedOverride.Name();
            derivedNew.Name();

            Console.ReadLine();
            baseClass.Name();
            derivedOverride.Name();
            ((BaseClass)derivedNew).Name();

            var t1 = typeof(BaseClass);
            Console.WriteLine(t1.Name);

            void List()
            {
                var objects = new ArrayList();
                objects.Add(1);
                objects.Add(2);
                objects.Add("three");
            }

            int count = 1;
            object countObject = count;
            count += 1;
            count = (int)countObject;

            void Breakfast()
            {
                var bird = new Animal<Egg>();
                var pig = new Animal<Piglet>();
            }
        }
    }
    public class Animal<T> where T : Offspring
    {
        public T Offspring { get; set; }
    }
    public abstract class Offspring { }
    public class Egg : Offspring { }
    public class Piglet : Offspring { }
    internal class BaseClass
    {
        internal virtual void Name()
        {
            Console.WriteLine("BaseClass");
        }
    }
    internal class DerivedOverride : BaseClass
    {
        internal override void Name()
        {
            Console.WriteLine("DerivedOverride");
        }
    }
    internal class DerivedNew : BaseClass
    {
        internal new void Name()
        {
            Console.WriteLine("New");
        }
    }
    public class Class1
    {
        public string Name { get; set; }
    }
    public class Class2: Class1
    {
        public int Age { get; set; }
    }
    public class Class3: Class2
    {
        public string Address { get; set; }
    }
    public class Trainer
    {
        void Operator()
        {
            var dog = new Poodle();
            dog.HasSpoken += dog_HasSpoken;
        }
        void dog_HasSpoken(object sender, EventArgs a)
        {
            throw new NotImplementedException();
        }
    }
    public partial class Dog
    {
        public string Name { get; set; }
        private string _name;
        public string Namee
        {
            get { return _name; }
            set { _name = value; }
        }
        private void Foo() { }
        protected void Bar() { }
        internal void Barr() { }
        public event EventHandler HasSpoken;
        public void speak(string what = "bark")
        {

        }
        public void speak(int times, string what = "bark", bool sit = true)
        {

        }
    }
    class Poodle : Dog
    {
        void x()
        {
            this.speak(2, "woof");
        }
    }
}
