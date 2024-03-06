namespace ToTheMoon
{
    public class Rocket
    {
        public bool StartIndicator { get; set; }
        public Motor MotorOne { get; set; }
        public Motor MotorTwo { get; set; }

        public Rocket(bool startIndicator)
        {
            StartIndicator = startIndicator;
            MotorOne = new Motor(15);
            MotorTwo = new Motor(20);
        }

        public void SwitchPower()
        {
            if (StartIndicator) StartIndicator = false;
            else StartIndicator = true;
        }
    }
}
