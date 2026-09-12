using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    public class Person
    {
        private string _name = string.Empty;
        private int _age;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        
        public virtual void info()
        {
            Console.WriteLine($"{Name} has {Age} old");
        }
    }
}
