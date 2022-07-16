using System;
namespace MyFirstProject
{
    public class EmptyClass
    {
        public EventHandler<int> someEvent;
        public string Name { get; set; }
        public EmptyClass()
        {
        }
        public void method()
        {
            Console.WriteLine("This is method Empty class");
            someEvent.Invoke(this, 4);
        }
    }
}

