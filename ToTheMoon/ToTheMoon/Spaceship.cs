namespace ToTheMoon
{
    public class Spaceship : IFlyable
    {
        public LandingSystem LandingSystem { get; set; }
        public NavigationSystem NavigationSystem { get; set; }
        public Rocket Rocket { get; set; }
        public BoardComputer BoardComputer = new BoardComputer(50);
        public int OrbitationAngle { get; set; }

        public Spaceship(LandingSystem landingSystem, NavigationSystem navigationSystem, Rocket rocket)
        {
            LandingSystem = landingSystem;
            NavigationSystem = navigationSystem;
            Rocket = rocket;
        }

        public void ChangeOrbitalAngle(int angle)
        {
            OrbitationAngle = angle;
        }
    }
}
