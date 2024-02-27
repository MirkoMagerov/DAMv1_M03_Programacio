using System;

namespace OOP
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
