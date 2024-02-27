using System;

namespace OOP
{
    public class Cat
    {
        private string name;
        private string breed;
        private string favoriteFood;
        private int age;

        public Cat(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name
        {
            get {return name;}
            set { name = value;}
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void MakeMeowSound()
        {
            Console.WriteLine("Meow");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Wash()
        {
            Console.WriteLine("Wash");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Hunt()
        {
            Console.WriteLine("Hunt");
        }
    }
}
