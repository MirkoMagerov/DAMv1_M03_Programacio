namespace ToTheMoon
{
    public class Crew
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public Crew(string name, string description, int age, string job)
        {
            Name = name;
            Description = description;
            Age = age;
            Job = job;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Crew eating.");
        }
    }
}
