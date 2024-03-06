namespace ToTheMoon
{
    public class SubCommander : Crew
    {
        public string CrewRank { get; set; }

        public SubCommander(string name, string description, int age, string job, string crewRank) : base(name, description, age, job)
        {
            CrewRank = crewRank;
        }
    }
}
