using System;

namespace assessment
{
    public abstract class Person
    {
        protected int age;

        public string Name { get; private set; }

        protected Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public abstract void Introduce();

        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
    }
}
