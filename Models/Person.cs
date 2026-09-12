using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Models
{
    class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            private set { _name = Name; }
        }
        public int Age
        {
            get { return _age; }
            private set { _age = Age; }
        }
        public Person(string name, int age)
        {
            _age = age;
            _name = name;
        }

        
        public virtual void info()
        {
            Console.WriteLine($"{_name} has {_age} old");
        }
    }
}
