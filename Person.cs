using System;

namespace assessment
{
    public abstract class Person
    {
        // Fields
        protected int age;

        // Properties
        public string Name { get; protected set; }

        // Protected constructor (cannot create Person object)
        protected Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public abstract void Introduce();
        public abstract void ShowAge();
    }
}
