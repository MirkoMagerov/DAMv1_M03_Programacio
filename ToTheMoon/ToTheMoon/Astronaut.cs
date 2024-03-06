namespace ToTheMoon
{
    public class Astronaut : Crew
    {
        public int SpaceOperations { get; set; }

        public Astronaut(string name, string description, int age, string job, int spaceOperations) : base(name, description, age, job)
        {
            SpaceOperations = spaceOperations;
        }
    }
}
