using System;

namespace polymorphism
{
    public class Parent
    {
        public void Speak()
        {
            Console.WriteLine("I am a parent");
        }
    }
    public class Child : Parent
    {
        public new void Speak()
        {
            Console.WriteLine("I am a child");
        }
    }
    public class Grandchild : Child
    {
        public new void Speak()
        {
            Console.WriteLine("I am a grandchild");
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Parent First = new Parent();
            Parent Second = new Child();
            Parent Third = new Grandchild();
            First.Speak();
            Second.Speak();
            Third.Speak();

            (Second as Child).Speak();
            (Third as Child).Speak();

            (Third as Grandchild).Speak();

            // TEST to fail for example -- (First as Child).Speak(); // this will Fail

            // TEST TO FAIL --- Child FirstTest = new Parent(); // this Fails

            Child SecondTest = new Grandchild();
            SecondTest.Speak();
            (SecondTest as Grandchild).Speak();

            
        }
    }
}
